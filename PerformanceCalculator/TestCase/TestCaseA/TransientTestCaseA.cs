using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseA
{
    public class TransientTestCaseA : TestCase
    {
        public TransientTestCaseA(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            _registration.RegisterTransient<ITestA0, TestA0>(container);
            _registration.RegisterTransient<ITestA1, TestA1>(container);
            _registration.RegisterTransient<ITestA2, TestA2>(container);
            _registration.RegisterTransient<ITestA3, TestA3>(container);
            _registration.RegisterTransient<ITestA4, TestA4>(container);
            _registration.RegisterTransient<ITestA5, TestA5>(container);
            _registration.RegisterTransient<ITestA6, TestA6>(container);
            _registration.RegisterTransient<ITestA7, TestA7>(container);
            _registration.RegisterTransient<ITestA8, TestA8>(container);
            _registration.RegisterTransient<ITestA9, TestA9>(container);
            _registration.RegisterTransient<ITestA, TestA>(container);
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestA>(container, testCasesNumber);
        }
    }
}