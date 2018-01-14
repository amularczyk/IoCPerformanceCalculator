using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseB
{
    public class SingletonTestCaseB : TestCase
    {
        public SingletonTestCaseB(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            _registration.RegisterSingleton<ITestBa0, TestBa0>(container);
            _registration.RegisterSingleton<ITestBa1, TestBa1>(container);
            _registration.RegisterSingleton<ITestBa2, TestBa2>(container);
            _registration.RegisterSingleton<ITestBa3, TestBa3>(container);
            _registration.RegisterSingleton<ITestBa4, TestBa4>(container);
            _registration.RegisterSingleton<ITestBa5, TestBa5>(container);
            _registration.RegisterSingleton<ITestBa6, TestBa6>(container);
            _registration.RegisterSingleton<ITestBa7, TestBa7>(container);
            _registration.RegisterSingleton<ITestBa8, TestBa8>(container);
            _registration.RegisterSingleton<ITestBa9, TestBa9>(container);
            _registration.RegisterSingleton<ITestBa10, TestBa10>(container);

            _registration.RegisterSingleton<ITestBb0, TestBb0>(container);
            _registration.RegisterSingleton<ITestBb1, TestBb1>(container);
            _registration.RegisterSingleton<ITestBb2, TestBb2>(container);
            _registration.RegisterSingleton<ITestBb3, TestBb3>(container);
            _registration.RegisterSingleton<ITestBb4, TestBb4>(container);
            _registration.RegisterSingleton<ITestBb5, TestBb5>(container);
            _registration.RegisterSingleton<ITestBb6, TestBb6>(container);
            _registration.RegisterSingleton<ITestBb7, TestBb7>(container);
            _registration.RegisterSingleton<ITestBb8, TestBb8>(container);
            _registration.RegisterSingleton<ITestBb9, TestBb9>(container);
            _registration.RegisterSingleton<ITestBb10, TestBb10>(container);

            _registration.RegisterSingleton<ITestBc0, TestBc0>(container);
            _registration.RegisterSingleton<ITestBc1, TestBc1>(container);
            _registration.RegisterSingleton<ITestBc2, TestBc2>(container);
            _registration.RegisterSingleton<ITestBc3, TestBc3>(container);
            _registration.RegisterSingleton<ITestBc4, TestBc4>(container);
            _registration.RegisterSingleton<ITestBc5, TestBc5>(container);
            _registration.RegisterSingleton<ITestBc6, TestBc6>(container);
            _registration.RegisterSingleton<ITestBc7, TestBc7>(container);
            _registration.RegisterSingleton<ITestBc8, TestBc8>(container);
            _registration.RegisterSingleton<ITestBc9, TestBc9>(container);
            _registration.RegisterSingleton<ITestBc10, TestBc10>(container);

            _registration.RegisterSingleton<ITestB, TestB>(container);
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestB>(container, testCasesNumber);
        }
    }
}