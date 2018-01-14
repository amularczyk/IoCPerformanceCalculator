using System;
using System.Diagnostics;
using Castle.Windsor;
using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;

namespace PerformanceCalculator.Containers.TestsWindsor
{
    public class WindsorPerformanceTest : PerformanceTest
    {
        protected override IRegistration GetRegistration()
        {
            return new WindsorRegistration();
        }

        protected override IResolving GetResolving()
        {
            return new WindsorResolving();
        }

        protected override object GetContainer(RegistrationKind registrationKind)
        {
            return new WindsorContainer();
        }

        protected override long RunResolve(Stopwatch sw, ITestCase testCase, object container, int testCasesCount,
            RegistrationKind registrationKind)
        {
            try
            {
                return base.RunResolve(sw, testCase, container, testCasesCount, registrationKind);
            }
            catch (OutOfMemoryException)
            {
                return -1;
            }
        }

        protected override void RunDispose(object container)
        {
            ((WindsorContainer)container).Dispose();
        }
    }
}