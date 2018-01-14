using System;
using System.Diagnostics;
using Autofac;
using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;

namespace PerformanceCalculator.Containers.TestsAutofac
{
    public class AutofacPerformanceTest : PerformanceTest
    {
        protected override IRegistration GetRegistration()
        {
            return new AutofacRegistration();
        }

        protected override IResolving GetResolving()
        {
            return new AutofacResolving();
        }

        protected override object GetContainer(RegistrationKind registrationKind)
        {
            return new ContainerBuilder();
        }

        protected override long RunResolve(Stopwatch sw, ITestCase testCase, object container, int testCasesCount,
            RegistrationKind registrationKind)
        {
            try
            {
                if (registrationKind == RegistrationKind.PerThread)
                {
                    sw.Start();
                    using (var threadLifetime = ((IContainer)container).BeginLifetimeScope())
                    {
                        testCase.Resolve(threadLifetime, testCasesCount);
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
            ((IContainer)container).Dispose();
        }
    }
}