using System;
using System.Diagnostics;
using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;
using SimpleInjector;

namespace PerformanceCalculator.Containers.TestsSimpleInjector
{
    public class SimpleInjectorPerformanceTest : PerformanceTest
    {
        protected override IRegistration GetRegistration()
        {
            return new SimpleInjectorRegistration();
        }

        protected override IResolving GetResolving()
        {
            return new SimpleInjectorResolving();
        }

        protected override object GetContainer(RegistrationKind registrationKind)
        {
            return new Container();
        }

        protected override long RunResolve(Stopwatch sw, ITestCase testCase, object container, int testCasesCount,
            RegistrationKind registrationKind)
        {
            try
            {
                if (registrationKind == RegistrationKind.PerThread)
                {
                    sw.Start();
                    using (((Container)container).BeginLifetimeScope())
                    {
                        testCase.Resolve(container, testCasesCount);
                    }
                    sw.Stop();
                    return sw.ElapsedMilliseconds;
                }

                return base.RunResolve(sw, testCase, container, testCasesCount, registrationKind);
            }
            catch (OutOfMemoryException)
            {
                return -1;
            }
        }

        protected override void RunDispose(object container)
        {
            ((Container)container).Dispose();
        }
    }
}