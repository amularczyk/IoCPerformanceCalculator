using System;
using System.Diagnostics;
using Grace.DependencyInjection;
using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;

namespace PerformanceCalculator.Containers.TestsGrace
{
    public class GracePerformanceTest : PerformanceTest
    {
        protected override IRegistration GetRegistration()
        {
            return new GraceRegistration();
        }

        protected override IResolving GetResolving()
        {
            return new GraceResolving();
        }

        protected override object GetContainer(RegistrationKind registrationKind)
        {
            return new DependencyInjectionContainer();
        }

        protected override long RunResolve(Stopwatch sw, ITestCase testCase, object container, int testCasesCount,
            RegistrationKind registrationKind)
        {
            try
            {
                if (registrationKind == RegistrationKind.PerThread)
                {
                    sw.Start();
                    using (var scope = ((DependencyInjectionContainer)container).BeginLifetimeScope())
                    {
                        testCase.Resolve(scope, testCasesCount);
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
            ((DependencyInjectionContainer)container).Dispose();
        }
    }
}