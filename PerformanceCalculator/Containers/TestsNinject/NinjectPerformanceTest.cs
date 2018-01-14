using System;
using System.Diagnostics;
using Ninject;
using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;

namespace PerformanceCalculator.Containers.TestsNinject
{
    public class NinjectPerformanceTest : PerformanceTest
    {
        protected override IRegistration GetRegistration()
        {
            return new NinjectRegistration();
        }

        protected override IResolving GetResolving()
        {
            return new NinjectResolving();
        }

        protected override object GetContainer(RegistrationKind registrationKind)
        {
            return new StandardKernel();
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
            ((StandardKernel)container).Dispose();
        }
    }
}