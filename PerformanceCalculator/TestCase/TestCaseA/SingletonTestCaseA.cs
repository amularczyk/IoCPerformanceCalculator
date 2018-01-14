using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseA
{
    public class SingletonTestCaseA : TestCase
    {
        public SingletonTestCaseA(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            _registration.RegisterSingleton<ITestA0, TestA0>(container);
            _registration.RegisterSingleton<ITestA1, TestA1>(container);
            _registration.RegisterSingleton<ITestA2, TestA2>(container);
            _registration.RegisterSingleton<ITestA3, TestA3>(container);
            _registration.RegisterSingleton<ITestA4, TestA4>(container);
            _registration.RegisterSingleton<ITestA5, TestA5>(container);
            _registration.RegisterSingleton<ITestA6, TestA6>(container);
            _registration.RegisterSingleton<ITestA7, TestA7>(container);
            _registration.RegisterSingleton<ITestA8, TestA8>(container);
            _registration.RegisterSingleton<ITestA9, TestA9>(container);
            _registration.RegisterSingleton<ITestA, TestA>(container);
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestA>(container, testCasesNumber);
        }
    }
}