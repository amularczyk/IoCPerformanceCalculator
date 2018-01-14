using System;
using System.Diagnostics;
using LightInject;
using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCase.TestCaseD;

namespace PerformanceCalculator.Containers.TestsLightInject
{
    public class LightInjectPerformanceTest : PerformanceTest
    {
        protected override IRegistration GetRegistration()
        {
            return new LightInjectRegistration();
        }

        protected override IResolving GetResolving()
        {
            return new LightInjectResolving();
        }

        protected override object GetContainer(RegistrationKind registrationKind)
        {
            return new ServiceContainer();
        }

        protected override long RunResolve(Stopwatch sw, ITestCase testCase, object container, int testCasesCount,
            RegistrationKind registrationKind)
        {
            try
            {
                if (registrationKind == RegistrationKind.PerThread)
                {
                    if (testCase is PerThreadTestCaseD)
                    {
                        throw new OutOfMemoryException("Process takes more than 20 minutes!");
                    }

                    sw.Start();
                    using (((ServiceContainer)container).BeginScope())
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
            ((ServiceContainer)container).Dispose();
        }
    }
}