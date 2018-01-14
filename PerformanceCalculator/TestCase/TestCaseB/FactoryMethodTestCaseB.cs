using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseB
{
    public class FactoryMethodTestCaseB : TestCase
    {
        public FactoryMethodTestCaseB(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            #region TestBa0

            _registration.RegisterFactoryMethod<ITestBa0, TestBa0>(container, c =>
            {
                var testBa0 = new TestBa0();

                return testBa0;
            });
            _registration.RegisterFactoryMethod<ITestBa1, TestBa1>(container, c =>
            {
                var testBa0 = _resolving.Resolve<ITestBa0>(c);

                var testBa1 = new TestBa1(testBa0);

                return testBa1;
            });
            _registration.RegisterFactoryMethod<ITestBa2, TestBa2>(container, c =>
            {
                var testBa0 = _resolving.Resolve<ITestBa0>(c);
                var testBa1 = _resolving.Resolve<ITestBa1>(c);

                var testBa2 = new TestBa2(testBa0, testBa1);

                return testBa2;
            });
            _registration.RegisterFactoryMethod<ITestBa3, TestBa3>(container, c =>
            {
                var testBa0 = _resolving.Resolve<ITestBa0>(c);
                var testBa1 = _resolving.Resolve<ITestBa1>(c);
                var testBa2 = _resolving.Resolve<ITestBa2>(c);

                var testBa3 = new TestBa3(testBa0, testBa1, testBa2);

                return testBa3;
            });
            _registration.RegisterFactoryMethod<ITestBa4, TestBa4>(container, c =>
            {
                var testBa0 = _resolving.Resolve<ITestBa0>(c);
                var testBa1 = _resolving.Resolve<ITestBa1>(c);
                var testBa2 = _resolving.Resolve<ITestBa2>(c);
                var testBa3 = _resolving.Resolve<ITestBa3>(c);

                var testBa4 = new TestBa4(testBa0, testBa1, testBa2, testBa3);

                return testBa4;
            });
            _registration.RegisterFactoryMethod<ITestBa5, TestBa5>(container, c =>
            {
                var testBa0 = _resolving.Resolve<ITestBa0>(c);
                var testBa1 = _resolving.Resolve<ITestBa1>(c);
                var testBa2 = _resolving.Resolve<ITestBa2>(c);
                var testBa3 = _resolving.Resolve<ITestBa3>(c);
                var testBa4 = _resolving.Resolve<ITestBa4>(c);

                var testBa5 = new TestBa5(testBa0, testBa1, testBa2, testBa3, testBa4);

                return testBa5;
            });
            _registration.RegisterFactoryMethod<ITestBa6, TestBa6>(container, c =>
            {
                var testBa0 = _resolving.Resolve<ITestBa0>(c);
                var testBa1 = _resolving.Resolve<ITestBa1>(c);
                var testBa2 = _resolving.Resolve<ITestBa2>(c);
                var testBa3 = _resolving.Resolve<ITestBa3>(c);
                var testBa4 = _resolving.Resolve<ITestBa4>(c);
                var testBa5 = _resolving.Resolve<ITestBa5>(c);

                var testBa6 = new TestBa6(testBa0, testBa1, testBa2, testBa3, testBa4, testBa5);

                return testBa6;
            });
            _registration.RegisterFactoryMethod<ITestBa7, TestBa7>(container, c =>
            {
                var testBa0 = _resolving.Resolve<ITestBa0>(c);
                var testBa1 = _resolving.Resolve<ITestBa1>(c);
                var testBa2 = _resolving.Resolve<ITestBa2>(c);
                var testBa3 = _resolving.Resolve<ITestBa3>(c);
                var testBa4 = _resolving.Resolve<ITestBa4>(c);
                var testBa5 = _resolving.Resolve<ITestBa5>(c);
                var testBa6 = _resolving.Resolve<ITestBa6>(c);

                var testBa7 = new TestBa7(testBa0, testBa1, testBa2, testBa3, testBa4, testBa5, testBa6);

                return testBa7;
            });
            _registration.RegisterFactoryMethod<ITestBa8, TestBa8>(container, c =>
            {
                var testBa0 = _resolving.Resolve<ITestBa0>(c);
                var testBa1 = _resolving.Resolve<ITestBa1>(c);
                var testBa2 = _resolving.Resolve<ITestBa2>(c);
                var testBa3 = _resolving.Resolve<ITestBa3>(c);
                var testBa4 = _resolving.Resolve<ITestBa4>(c);
                var testBa5 = _resolving.Resolve<ITestBa5>(c);
                var testBa6 = _resolving.Resolve<ITestBa6>(c);
                var testBa7 = _resolving.Resolve<ITestBa7>(c);

                var testBa8 = new TestBa8(testBa0, testBa1, testBa2, testBa3, testBa4, testBa5, testBa6, testBa7);

                return testBa8;
            });
            _registration.RegisterFactoryMethod<ITestBa9, TestBa9>(container, c =>
            {
                var testBa0 = _resolving.Resolve<ITestBa0>(c);
                var testBa1 = _resolving.Resolve<ITestBa1>(c);
                var testBa2 = _resolving.Resolve<ITestBa2>(c);
                var testBa3 = _resolving.Resolve<ITestBa3>(c);
                var testBa4 = _resolving.Resolve<ITestBa4>(c);
                var testBa5 = _resolving.Resolve<ITestBa5>(c);
                var testBa6 = _resolving.Resolve<ITestBa6>(c);
                var testBa7 = _resolving.Resolve<ITestBa7>(c);
                var testBa8 = _resolving.Resolve<ITestBa8>(c);

                var testBa9 = new TestBa9(testBa0, testBa1, testBa2, testBa3, testBa4, testBa5, testBa6, testBa7,
                    testBa8);

                return testBa9;
            });
            _registration.RegisterFactoryMethod<ITestBa10, TestBa10>(container, c =>
            {
                var testBa0 = _resolving.Resolve<ITestBa0>(c);
                var testBa1 = _resolving.Resolve<ITestBa1>(c);
                var testBa2 = _resolving.Resolve<ITestBa2>(c);
                var testBa3 = _resolving.Resolve<ITestBa3>(c);
                var testBa4 = _resolving.Resolve<ITestBa4>(c);
                var testBa5 = _resolving.Resolve<ITestBa5>(c);
                var testBa6 = _resolving.Resolve<ITestBa6>(c);
                var testBa7 = _resolving.Resolve<ITestBa7>(c);
                var testBa8 = _resolving.Resolve<ITestBa8>(c);
                var testBa9 = _resolving.Resolve<ITestBa9>(c);

                var testBa10 = new TestBa10(testBa0, testBa1, testBa2, testBa3, testBa4, testBa5, testBa6, testBa7,
                    testBa8, testBa9);

                return testBa10;
            });

            #endregion

            #region TestBb0

            _registration.RegisterFactoryMethod<ITestBb0, TestBb0>(container, c =>
            {
                var testBb0 = new TestBb0();

                return testBb0;
            });
            _registration.RegisterFactoryMethod<ITestBb1, TestBb1>(container, c =>
            {
                var testBb0 = _resolving.Resolve<ITestBb0>(c);

                var testBb1 = new TestBb1(testBb0);

                return testBb1;
            });
            _registration.RegisterFactoryMethod<ITestBb2, TestBb2>(container, c =>
            {
                var testBb0 = _resolving.Resolve<ITestBb0>(c);
                var testBb1 = _resolving.Resolve<ITestBb1>(c);

                var testBb2 = new TestBb2(testBb0, testBb1);

                return testBb2;
            });
            _registration.RegisterFactoryMethod<ITestBb3, TestBb3>(container, c =>
            {
                var testBb0 = _resolving.Resolve<ITestBb0>(c);
                var testBb1 = _resolving.Resolve<ITestBb1>(c);
                var testBb2 = _resolving.Resolve<ITestBb2>(c);

                var testBb3 = new TestBb3(testBb0, testBb1, testBb2);

                return testBb3;
            });
            _registration.RegisterFactoryMethod<ITestBb4, TestBb4>(container, c =>
            {
                var testBb0 = _resolving.Resolve<ITestBb0>(c);
                var testBb1 = _resolving.Resolve<ITestBb1>(c);
                var testBb2 = _resolving.Resolve<ITestBb2>(c);
                var testBb3 = _resolving.Resolve<ITestBb3>(c);

                var testBb4 = new TestBb4(testBb0, testBb1, testBb2, testBb3);

                return testBb4;
            });
            _registration.RegisterFactoryMethod<ITestBb5, TestBb5>(container, c =>
            {
                var testBb0 = _resolving.Resolve<ITestBb0>(c);
                var testBb1 = _resolving.Resolve<ITestBb1>(c);
                var testBb2 = _resolving.Resolve<ITestBb2>(c);
                var testBb3 = _resolving.Resolve<ITestBb3>(c);
                var testBb4 = _resolving.Resolve<ITestBb4>(c);

                var testBb5 = new TestBb5(testBb0, testBb1, testBb2, testBb3, testBb4);

                return testBb5;
            });
            _registration.RegisterFactoryMethod<ITestBb6, TestBb6>(container, c =>
            {
                var testBb0 = _resolving.Resolve<ITestBb0>(c);
                var testBb1 = _resolving.Resolve<ITestBb1>(c);
                var testBb2 = _resolving.Resolve<ITestBb2>(c);
                var testBb3 = _resolving.Resolve<ITestBb3>(c);
                var testBb4 = _resolving.Resolve<ITestBb4>(c);
                var testBb5 = _resolving.Resolve<ITestBb5>(c);

                var testBb6 = new TestBb6(testBb0, testBb1, testBb2, testBb3, testBb4, testBb5);

                return testBb6;
            });
            _registration.RegisterFactoryMethod<ITestBb7, TestBb7>(container, c =>
            {
                var testBb0 = _resolving.Resolve<ITestBb0>(c);
                var testBb1 = _resolving.Resolve<ITestBb1>(c);
                var testBb2 = _resolving.Resolve<ITestBb2>(c);
                var testBb3 = _resolving.Resolve<ITestBb3>(c);
                var testBb4 = _resolving.Resolve<ITestBb4>(c);
                var testBb5 = _resolving.Resolve<ITestBb5>(c);
                var testBb6 = _resolving.Resolve<ITestBb6>(c);

                var testBb7 = new TestBb7(testBb0, testBb1, testBb2, testBb3, testBb4, testBb5, testBb6);

                return testBb7;
            });
            _registration.RegisterFactoryMethod<ITestBb8, TestBb8>(container, c =>
            {
                var testBb0 = _resolving.Resolve<ITestBb0>(c);
                var testBb1 = _resolving.Resolve<ITestBb1>(c);
                var testBb2 = _resolving.Resolve<ITestBb2>(c);
                var testBb3 = _resolving.Resolve<ITestBb3>(c);
                var testBb4 = _resolving.Resolve<ITestBb4>(c);
                var testBb5 = _resolving.Resolve<ITestBb5>(c);
                var testBb6 = _resolving.Resolve<ITestBb6>(c);
                var testBb7 = _resolving.Resolve<ITestBb7>(c);

                var testBb8 = new TestBb8(testBb0, testBb1, testBb2, testBb3, testBb4, testBb5, testBb6, testBb7);

                return testBb8;
            });
            _registration.RegisterFactoryMethod<ITestBb9, TestBb9>(container, c =>
            {
                var testBb0 = _resolving.Resolve<ITestBb0>(c);
                var testBb1 = _resolving.Resolve<ITestBb1>(c);
                var testBb2 = _resolving.Resolve<ITestBb2>(c);
                var testBb3 = _resolving.Resolve<ITestBb3>(c);
                var testBb4 = _resolving.Resolve<ITestBb4>(c);
                var testBb5 = _resolving.Resolve<ITestBb5>(c);
                var testBb6 = _resolving.Resolve<ITestBb6>(c);
                var testBb7 = _resolving.Resolve<ITestBb7>(c);
                var testBb8 = _resolving.Resolve<ITestBb8>(c);

                var testBb9 = new TestBb9(testBb0, testBb1, testBb2, testBb3, testBb4, testBb5, testBb6, testBb7,
                    testBb8);

                return testBb9;
            });
            _registration.RegisterFactoryMethod<ITestBb10, TestBb10>(container, c =>
            {
                var testBb0 = _resolving.Resolve<ITestBb0>(c);
                var testBb1 = _resolving.Resolve<ITestBb1>(c);
                var testBb2 = _resolving.Resolve<ITestBb2>(c);
                var testBb3 = _resolving.Resolve<ITestBb3>(c);
                var testBb4 = _resolving.Resolve<ITestBb4>(c);
                var testBb5 = _resolving.Resolve<ITestBb5>(c);
                var testBb6 = _resolving.Resolve<ITestBb6>(c);
                var testBb7 = _resolving.Resolve<ITestBb7>(c);
                var testBb8 = _resolving.Resolve<ITestBb8>(c);
                var testBb9 = _resolving.Resolve<ITestBb9>(c);

                var testBb10 = new TestBb10(testBb0, testBb1, testBb2, testBb3, testBb4, testBb5, testBb6, testBb7,
                    testBb8, testBb9);

                return testBb10;
            });

            #endregion

            #region TestBc0

            _registration.RegisterFactoryMethod<ITestBc0, TestBc0>(container, c =>
            {
                var testBc0 = new TestBc0();

                return testBc0;
            });
            _registration.RegisterFactoryMethod<ITestBc1, TestBc1>(container, c =>
            {
                var testBc0 = _resolving.Resolve<ITestBc0>(c);

                var testBc1 = new TestBc1(testBc0);

                return testBc1;
            });
            _registration.RegisterFactoryMethod<ITestBc2, TestBc2>(container, c =>
            {
                var testBc0 = _resolving.Resolve<ITestBc0>(c);
                var testBc1 = _resolving.Resolve<ITestBc1>(c);

                var testBc2 = new TestBc2(testBc0, testBc1);

                return testBc2;
            });
            _registration.RegisterFactoryMethod<ITestBc3, TestBc3>(container, c =>
            {
                var testBc0 = _resolving.Resolve<ITestBc0>(c);
                var testBc1 = _resolving.Resolve<ITestBc1>(c);
                var testBc2 = _resolving.Resolve<ITestBc2>(c);

                var testBc3 = new TestBc3(testBc0, testBc1, testBc2);

                return testBc3;
            });
            _registration.RegisterFactoryMethod<ITestBc4, TestBc4>(container, c =>
            {
                var testBc0 = _resolving.Resolve<ITestBc0>(c);
                var testBc1 = _resolving.Resolve<ITestBc1>(c);
                var testBc2 = _resolving.Resolve<ITestBc2>(c);
                var testBc3 = _resolving.Resolve<ITestBc3>(c);

                var testBc4 = new TestBc4(testBc0, testBc1, testBc2, testBc3);

                return testBc4;
            });
            _registration.RegisterFactoryMethod<ITestBc5, TestBc5>(container, c =>
            {
                var testBc0 = _resolving.Resolve<ITestBc0>(c);
                var testBc1 = _resolving.Resolve<ITestBc1>(c);
                var testBc2 = _resolving.Resolve<ITestBc2>(c);
                var testBc3 = _resolving.Resolve<ITestBc3>(c);
                var testBc4 = _resolving.Resolve<ITestBc4>(c);

                var testBc5 = new TestBc5(testBc0, testBc1, testBc2, testBc3, testBc4);

                return testBc5;
            });
            _registration.RegisterFactoryMethod<ITestBc6, TestBc6>(container, c =>
            {
                var testBc0 = _resolving.Resolve<ITestBc0>(c);
                var testBc1 = _resolving.Resolve<ITestBc1>(c);
                var testBc2 = _resolving.Resolve<ITestBc2>(c);
                var testBc3 = _resolving.Resolve<ITestBc3>(c);
                var testBc4 = _resolving.Resolve<ITestBc4>(c);
                var testBc5 = _resolving.Resolve<ITestBc5>(c);

                var testBc6 = new TestBc6(testBc0, testBc1, testBc2, testBc3, testBc4, testBc5);

                return testBc6;
            });
            _registration.RegisterFactoryMethod<ITestBc7, TestBc7>(container, c =>
            {
                var testBc0 = _resolving.Resolve<ITestBc0>(c);
                var testBc1 = _resolving.Resolve<ITestBc1>(c);
                var testBc2 = _resolving.Resolve<ITestBc2>(c);
                var testBc3 = _resolving.Resolve<ITestBc3>(c);
                var testBc4 = _resolving.Resolve<ITestBc4>(c);
                var testBc5 = _resolving.Resolve<ITestBc5>(c);
                var testBc6 = _resolving.Resolve<ITestBc6>(c);

                var testBc7 = new TestBc7(testBc0, testBc1, testBc2, testBc3, testBc4, testBc5, testBc6);

                return testBc7;
            });
            _registration.RegisterFactoryMethod<ITestBc8, TestBc8>(container, c =>
            {
                var testBc0 = _resolving.Resolve<ITestBc0>(c);
                var testBc1 = _resolving.Resolve<ITestBc1>(c);
                var testBc2 = _resolving.Resolve<ITestBc2>(c);
                var testBc3 = _resolving.Resolve<ITestBc3>(c);
                var testBc4 = _resolving.Resolve<ITestBc4>(c);
                var testBc5 = _resolving.Resolve<ITestBc5>(c);
                var testBc6 = _resolving.Resolve<ITestBc6>(c);
                var testBc7 = _resolving.Resolve<ITestBc7>(c);

                var testBc8 = new TestBc8(testBc0, testBc1, testBc2, testBc3, testBc4, testBc5, testBc6, testBc7);

                return testBc8;
            });
            _registration.RegisterFactoryMethod<ITestBc9, TestBc9>(container, c =>
            {
                var testBc0 = _resolving.Resolve<ITestBc0>(c);
                var testBc1 = _resolving.Resolve<ITestBc1>(c);
                var testBc2 = _resolving.Resolve<ITestBc2>(c);
                var testBc3 = _resolving.Resolve<ITestBc3>(c);
                var testBc4 = _resolving.Resolve<ITestBc4>(c);
                var testBc5 = _resolving.Resolve<ITestBc5>(c);
                var testBc6 = _resolving.Resolve<ITestBc6>(c);
                var testBc7 = _resolving.Resolve<ITestBc7>(c);
                var testBc8 = _resolving.Resolve<ITestBc8>(c);

                var testBc9 = new TestBc9(testBc0, testBc1, testBc2, testBc3, testBc4, testBc5, testBc6, testBc7,
                    testBc8);

                return testBc9;
            });
            _registration.RegisterFactoryMethod<ITestBc10, TestBc10>(container, c =>
            {
                var testBc0 = _resolving.Resolve<ITestBc0>(c);
                var testBc1 = _resolving.Resolve<ITestBc1>(c);
                var testBc2 = _resolving.Resolve<ITestBc2>(c);
                var testBc3 = _resolving.Resolve<ITestBc3>(c);
                var testBc4 = _resolving.Resolve<ITestBc4>(c);
                var testBc5 = _resolving.Resolve<ITestBc5>(c);
                var testBc6 = _resolving.Resolve<ITestBc6>(c);
                var testBc7 = _resolving.Resolve<ITestBc7>(c);
                var testBc8 = _resolving.Resolve<ITestBc8>(c);
                var testBc9 = _resolving.Resolve<ITestBc9>(c);

                var testBc10 = new TestBc10(testBc0, testBc1, testBc2, testBc3, testBc4, testBc5, testBc6, testBc7,
                    testBc8, testBc9);

                return testBc10;
            });

            #endregion

            _registration.RegisterFactoryMethod<ITestB, TestB>(container, c =>
            {
                var testBa10 = _resolving.Resolve<ITestBa10>(c);
                var testBb10 = _resolving.Resolve<ITestBb10>(c);
                var testBc10 = _resolving.Resolve<ITestBc10>(c);

                var testB = new TestB(testBa10, testBb10, testBc10);

                return testB;
            });
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestB>(container, testCasesNumber);
        }
    }
}