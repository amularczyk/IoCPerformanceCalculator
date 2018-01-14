using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseB
{
    public class PerThreadTestCaseB : TestCase
    {
        public PerThreadTestCaseB(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            _registration.RegisterPerThread<ITestBa0, TestBa0>(container);
            _registration.RegisterPerThread<ITestBa1, TestBa1>(container);
            _registration.RegisterPerThread<ITestBa2, TestBa2>(container);
            _registration.RegisterPerThread<ITestBa3, TestBa3>(container);
            _registration.RegisterPerThread<ITestBa4, TestBa4>(container);
            _registration.RegisterPerThread<ITestBa5, TestBa5>(container);
            _registration.RegisterPerThread<ITestBa6, TestBa6>(container);
            _registration.RegisterPerThread<ITestBa7, TestBa7>(container);
            _registration.RegisterPerThread<ITestBa8, TestBa8>(container);
            _registration.RegisterPerThread<ITestBa9, TestBa9>(container);
            _registration.RegisterPerThread<ITestBa10, TestBa10>(container);

            _registration.RegisterPerThread<ITestBb0, TestBb0>(container);
            _registration.RegisterPerThread<ITestBb1, TestBb1>(container);
            _registration.RegisterPerThread<ITestBb2, TestBb2>(container);
            _registration.RegisterPerThread<ITestBb3, TestBb3>(container);
            _registration.RegisterPerThread<ITestBb4, TestBb4>(container);
            _registration.RegisterPerThread<ITestBb5, TestBb5>(container);
            _registration.RegisterPerThread<ITestBb6, TestBb6>(container);
            _registration.RegisterPerThread<ITestBb7, TestBb7>(container);
            _registration.RegisterPerThread<ITestBb8, TestBb8>(container);
            _registration.RegisterPerThread<ITestBb9, TestBb9>(container);
            _registration.RegisterPerThread<ITestBb10, TestBb10>(container);

            _registration.RegisterPerThread<ITestBc0, TestBc0>(container);
            _registration.RegisterPerThread<ITestBc1, TestBc1>(container);
            _registration.RegisterPerThread<ITestBc2, TestBc2>(container);
            _registration.RegisterPerThread<ITestBc3, TestBc3>(container);
            _registration.RegisterPerThread<ITestBc4, TestBc4>(container);
            _registration.RegisterPerThread<ITestBc5, TestBc5>(container);
            _registration.RegisterPerThread<ITestBc6, TestBc6>(container);
            _registration.RegisterPerThread<ITestBc7, TestBc7>(container);
            _registration.RegisterPerThread<ITestBc8, TestBc8>(container);
            _registration.RegisterPerThread<ITestBc9, TestBc9>(container);
            _registration.RegisterPerThread<ITestBc10, TestBc10>(container);

            _registration.RegisterPerThread<ITestB, TestB>(container);
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestB>(container, testCasesNumber);
        }
    }
}