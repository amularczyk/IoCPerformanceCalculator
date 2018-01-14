using System;
using System.Diagnostics;
using DryIoc;
using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;

namespace PerformanceCalculator.Containers.TestsDryIoc
{
    public class DryIocPerformanceTest : PerformanceTest
    {
        protected override IRegistration GetRegistration()
        {
            return new DryIocRegistration();
        }

        protected override IResolving GetResolving()
        {
            return new DryIocResolving();
        }

        protected override object GetContainer(RegistrationKind registrationKind)
        {
            return registrationKind == RegistrationKind.PerThread
                ? new Container(scopeContext: new ThreadScopeContext())
                : new Container();
        }

        protected override long RunResolve(Stopwatch sw, ITestCase testCase, object container, int testCasesCount,
            RegistrationKind registrationKind)
        {
            try
            {
                if (registrationKind == RegistrationKind.PerThread)
                {
                    sw.Start();
                    using (((Container)container).OpenScope())
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