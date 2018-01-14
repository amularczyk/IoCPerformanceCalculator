using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseA
{
    public class FactoryMethodTestCaseA : TestCase
    {
        public FactoryMethodTestCaseA(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            #region TestA

            _registration.RegisterFactoryMethod<ITestA0, TestA0>(container, c =>
            {
                var testA0 = new TestA0();

                return testA0;
            });
            _registration.RegisterFactoryMethod<ITestA1, TestA1>(container, c =>
            {
                var testA0 = _resolving.Resolve<ITestA0>(c);

                var testA1 = new TestA1(testA0);

                return testA1;
            });
            _registration.RegisterFactoryMethod<ITestA2, TestA2>(container, c =>
            {
                var testA0 = _resolving.Resolve<ITestA0>(c);
                var testA1 = _resolving.Resolve<ITestA1>(c);

                var testA2 = new TestA2(testA0, testA1);

                return testA2;
            });
            _registration.RegisterFactoryMethod<ITestA3, TestA3>(container, c =>
            {
                var testA0 = _resolving.Resolve<ITestA0>(c);
                var testA1 = _resolving.Resolve<ITestA1>(c);
                var testA2 = _resolving.Resolve<ITestA2>(c);

                var testA3 = new TestA3(testA0, testA1, testA2);

                return testA3;
            });
            _registration.RegisterFactoryMethod<ITestA4, TestA4>(container, c =>
            {
                var testA0 = _resolving.Resolve<ITestA0>(c);
                var testA1 = _resolving.Resolve<ITestA1>(c);
                var testA2 = _resolving.Resolve<ITestA2>(c);
                var testA3 = _resolving.Resolve<ITestA3>(c);

                var testA4 = new TestA4(testA0, testA1, testA2, testA3);

                return testA4;
            });
            _registration.RegisterFactoryMethod<ITestA5, TestA5>(container, c =>
            {
                var testA0 = _resolving.Resolve<ITestA0>(c);
                var testA1 = _resolving.Resolve<ITestA1>(c);
                var testA2 = _resolving.Resolve<ITestA2>(c);
                var testA3 = _resolving.Resolve<ITestA3>(c);
                var testA4 = _resolving.Resolve<ITestA4>(c);

                var testA5 = new TestA5(testA0, testA1, testA2, testA3, testA4);

                return testA5;
            });
            _registration.RegisterFactoryMethod<ITestA6, TestA6>(container, c =>
            {
                var testA0 = _resolving.Resolve<ITestA0>(c);
                var testA1 = _resolving.Resolve<ITestA1>(c);
                var testA2 = _resolving.Resolve<ITestA2>(c);
                var testA3 = _resolving.Resolve<ITestA3>(c);
                var testA4 = _resolving.Resolve<ITestA4>(c);
                var testA5 = _resolving.Resolve<ITestA5>(c);

                var testA6 = new TestA6(testA0, testA1, testA2, testA3, testA4, testA5);

                return testA6;
            });
            _registration.RegisterFactoryMethod<ITestA7, TestA7>(container, c =>
            {
                var testA0 = _resolving.Resolve<ITestA0>(c);
                var testA1 = _resolving.Resolve<ITestA1>(c);
                var testA2 = _resolving.Resolve<ITestA2>(c);
                var testA3 = _resolving.Resolve<ITestA3>(c);
                var testA4 = _resolving.Resolve<ITestA4>(c);
                var testA5 = _resolving.Resolve<ITestA5>(c);
                var testA6 = _resolving.Resolve<ITestA6>(c);

                var testA7 = new TestA7(testA0, testA1, testA2, testA3, testA4, testA5, testA6);

                return testA7;
            });
            _registration.RegisterFactoryMethod<ITestA8, TestA8>(container, c =>
            {
                var testA0 = _resolving.Resolve<ITestA0>(c);
                var testA1 = _resolving.Resolve<ITestA1>(c);
                var testA2 = _resolving.Resolve<ITestA2>(c);
                var testA3 = _resolving.Resolve<ITestA3>(c);
                var testA4 = _resolving.Resolve<ITestA4>(c);
                var testA5 = _resolving.Resolve<ITestA5>(c);
                var testA6 = _resolving.Resolve<ITestA6>(c);
                var testA7 = _resolving.Resolve<ITestA7>(c);

                var testA8 = new TestA8(testA0, testA1, testA2, testA3, testA4, testA5, testA6, testA7);

                return testA8;
            });
            _registration.RegisterFactoryMethod<ITestA9, TestA9>(container, c =>
            {
                var testA0 = _resolving.Resolve<ITestA0>(c);
                var testA1 = _resolving.Resolve<ITestA1>(c);
                var testA2 = _resolving.Resolve<ITestA2>(c);
                var testA3 = _resolving.Resolve<ITestA3>(c);
                var testA4 = _resolving.Resolve<ITestA4>(c);
                var testA5 = _resolving.Resolve<ITestA5>(c);
                var testA6 = _resolving.Resolve<ITestA6>(c);
                var testA7 = _resolving.Resolve<ITestA7>(c);
                var testA8 = _resolving.Resolve<ITestA8>(c);

                var testA9 = new TestA9(testA0, testA1, testA2, testA3, testA4, testA5, testA6, testA7, testA8);

                return testA9;
            });

            #endregion

            _registration.RegisterFactoryMethod<ITestA, TestA>(container, c =>
            {
                var testA0 = _resolving.Resolve<ITestA0>(c);
                var testA1 = _resolving.Resolve<ITestA1>(c);
                var testA2 = _resolving.Resolve<ITestA2>(c);
                var testA3 = _resolving.Resolve<ITestA3>(c);
                var testA4 = _resolving.Resolve<ITestA4>(c);
                var testA5 = _resolving.Resolve<ITestA5>(c);
                var testA6 = _resolving.Resolve<ITestA6>(c);
                var testA7 = _resolving.Resolve<ITestA7>(c);
                var testA8 = _resolving.Resolve<ITestA8>(c);
                var testA9 = _resolving.Resolve<ITestA9>(c);

                var testA = new TestA(testA0, testA1, testA2, testA3, testA4, testA5, testA6, testA7, testA8, testA9);

                return testA;
            });
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestA>(container, testCasesNumber);
        }
    }
}