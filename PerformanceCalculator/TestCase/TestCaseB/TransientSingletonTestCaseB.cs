using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseB
{
    public class TransientSingletonTestCaseB : TestCase
    {
        public TransientSingletonTestCaseB(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            _registration.RegisterSingleton<ITestBa0, TestBa0>(container);
            _registration.RegisterTransient<ITestBa1, TestBa1>(container);
            _registration.RegisterTransient<ITestBa2, TestBa2>(container);
            _registration.RegisterTransient<ITestBa3, TestBa3>(container);
            _registration.RegisterTransient<ITestBa4, TestBa4>(container);
            _registration.RegisterTransient<ITestBa5, TestBa5>(container);
            _registration.RegisterTransient<ITestBa6, TestBa6>(container);
            _registration.RegisterTransient<ITestBa7, TestBa7>(container);
            _registration.RegisterTransient<ITestBa8, TestBa8>(container);
            _registration.RegisterTransient<ITestBa9, TestBa9>(container);
            _registration.RegisterTransient<ITestBa10, TestBa10>(container);

            _registration.RegisterSingleton<ITestBb0, TestBb0>(container);
            _registration.RegisterTransient<ITestBb1, TestBb1>(container);
            _registration.RegisterTransient<ITestBb2, TestBb2>(container);
            _registration.RegisterTransient<ITestBb3, TestBb3>(container);
            _registration.RegisterTransient<ITestBb4, TestBb4>(container);
            _registration.RegisterTransient<ITestBb5, TestBb5>(container);
            _registration.RegisterTransient<ITestBb6, TestBb6>(container);
            _registration.RegisterTransient<ITestBb7, TestBb7>(container);
            _registration.RegisterTransient<ITestBb8, TestBb8>(container);
            _registration.RegisterTransient<ITestBb9, TestBb9>(container);
            _registration.RegisterTransient<ITestBb10, TestBb10>(container);

            _registration.RegisterSingleton<ITestBc0, TestBc0>(container);
            _registration.RegisterTransient<ITestBc1, TestBc1>(container);
            _registration.RegisterTransient<ITestBc2, TestBc2>(container);
            _registration.RegisterTransient<ITestBc3, TestBc3>(container);
            _registration.RegisterTransient<ITestBc4, TestBc4>(container);
            _registration.RegisterTransient<ITestBc5, TestBc5>(container);
            _registration.RegisterTransient<ITestBc6, TestBc6>(container);
            _registration.RegisterTransient<ITestBc7, TestBc7>(container);
            _registration.RegisterTransient<ITestBc8, TestBc8>(container);
            _registration.RegisterTransient<ITestBc9, TestBc9>(container);
            _registration.RegisterTransient<ITestBc10, TestBc10>(container);

            _registration.RegisterTransient<ITestB, TestB>(container);
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestB>(container, testCasesNumber);
        }
    }
}