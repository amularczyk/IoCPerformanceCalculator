using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseA
{
    public class PerThreadTestCaseA : TestCase
    {
        public PerThreadTestCaseA(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            _registration.RegisterPerThread<ITestA0, TestA0>(container);
            _registration.RegisterPerThread<ITestA1, TestA1>(container);
            _registration.RegisterPerThread<ITestA2, TestA2>(container);
            _registration.RegisterPerThread<ITestA3, TestA3>(container);
            _registration.RegisterPerThread<ITestA4, TestA4>(container);
            _registration.RegisterPerThread<ITestA5, TestA5>(container);
            _registration.RegisterPerThread<ITestA6, TestA6>(container);
            _registration.RegisterPerThread<ITestA7, TestA7>(container);
            _registration.RegisterPerThread<ITestA8, TestA8>(container);
            _registration.RegisterPerThread<ITestA9, TestA9>(container);
            _registration.RegisterPerThread<ITestA, TestA>(container);
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestA>(container, testCasesNumber);
        }
    }
}