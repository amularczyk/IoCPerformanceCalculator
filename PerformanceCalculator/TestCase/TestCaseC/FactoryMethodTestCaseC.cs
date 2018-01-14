using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseC
{
    public class FactoryMethodTestCaseC : TestCase
    {
        public FactoryMethodTestCaseC(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            #region TestC0

            _registration.RegisterFactoryMethod<ITestC00, TestC00>(container, c =>
            {
                var testC = new TestC00();

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC01, TestC01>(container, c =>
            {
                var testC = new TestC01();

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC02, TestC02>(container, c =>
            {
                var testC = new TestC02();

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC03, TestC03>(container, c =>
            {
                var testC = new TestC03();

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC04, TestC04>(container, c =>
            {
                var testC = new TestC04();

                return testC;
            });

            #endregion

            #region TestC1

            _registration.RegisterFactoryMethod<ITestC10, TestC10>(container, c =>
            {
                var testC00 = _resolving.Resolve<ITestC00>(c);
                var testC01 = _resolving.Resolve<ITestC01>(c);
                var testC02 = _resolving.Resolve<ITestC02>(c);
                var testC03 = _resolving.Resolve<ITestC03>(c);
                var testC04 = _resolving.Resolve<ITestC04>(c);

                var testC = new TestC10(testC00, testC01, testC02, testC03, testC04);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC11, TestC11>(container, c =>
            {
                var testC00 = _resolving.Resolve<ITestC00>(c);
                var testC01 = _resolving.Resolve<ITestC01>(c);
                var testC02 = _resolving.Resolve<ITestC02>(c);
                var testC03 = _resolving.Resolve<ITestC03>(c);
                var testC04 = _resolving.Resolve<ITestC04>(c);

                var testC = new TestC11(testC00, testC01, testC02, testC03, testC04);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC12, TestC12>(container, c =>
            {
                var testC00 = _resolving.Resolve<ITestC00>(c);
                var testC01 = _resolving.Resolve<ITestC01>(c);
                var testC02 = _resolving.Resolve<ITestC02>(c);
                var testC03 = _resolving.Resolve<ITestC03>(c);
                var testC04 = _resolving.Resolve<ITestC04>(c);

                var testC = new TestC12(testC00, testC01, testC02, testC03, testC04);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC13, TestC13>(container, c =>
            {
                var testC00 = _resolving.Resolve<ITestC00>(c);
                var testC01 = _resolving.Resolve<ITestC01>(c);
                var testC02 = _resolving.Resolve<ITestC02>(c);
                var testC03 = _resolving.Resolve<ITestC03>(c);
                var testC04 = _resolving.Resolve<ITestC04>(c);

                var testC = new TestC13(testC00, testC01, testC02, testC03, testC04);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC14, TestC14>(container, c =>
            {
                var testC00 = _resolving.Resolve<ITestC00>(c);
                var testC01 = _resolving.Resolve<ITestC01>(c);
                var testC02 = _resolving.Resolve<ITestC02>(c);
                var testC03 = _resolving.Resolve<ITestC03>(c);
                var testC04 = _resolving.Resolve<ITestC04>(c);

                var testC = new TestC14(testC00, testC01, testC02, testC03, testC04);

                return testC;
            });

            #endregion

            #region TestC2

            _registration.RegisterFactoryMethod<ITestC20, TestC20>(container, c =>
            {
                var testC10 = _resolving.Resolve<ITestC10>(c);
                var testC11 = _resolving.Resolve<ITestC11>(c);
                var testC12 = _resolving.Resolve<ITestC12>(c);
                var testC13 = _resolving.Resolve<ITestC13>(c);
                var testC14 = _resolving.Resolve<ITestC14>(c);

                var testC = new TestC20(testC10, testC11, testC12, testC13, testC14);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC21, TestC21>(container, c =>
            {
                var testC10 = _resolving.Resolve<ITestC10>(c);
                var testC11 = _resolving.Resolve<ITestC11>(c);
                var testC12 = _resolving.Resolve<ITestC12>(c);
                var testC13 = _resolving.Resolve<ITestC13>(c);
                var testC14 = _resolving.Resolve<ITestC14>(c);

                var testC = new TestC21(testC10, testC11, testC12, testC13, testC14);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC22, TestC22>(container, c =>
            {
                var testC10 = _resolving.Resolve<ITestC10>(c);
                var testC11 = _resolving.Resolve<ITestC11>(c);
                var testC12 = _resolving.Resolve<ITestC12>(c);
                var testC13 = _resolving.Resolve<ITestC13>(c);
                var testC14 = _resolving.Resolve<ITestC14>(c);

                var testC = new TestC22(testC10, testC11, testC12, testC13, testC14);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC23, TestC23>(container, c =>
            {
                var testC10 = _resolving.Resolve<ITestC10>(c);
                var testC11 = _resolving.Resolve<ITestC11>(c);
                var testC12 = _resolving.Resolve<ITestC12>(c);
                var testC13 = _resolving.Resolve<ITestC13>(c);
                var testC14 = _resolving.Resolve<ITestC14>(c);

                var testC = new TestC23(testC10, testC11, testC12, testC13, testC14);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC24, TestC24>(container, c =>
            {
                var testC10 = _resolving.Resolve<ITestC10>(c);
                var testC11 = _resolving.Resolve<ITestC11>(c);
                var testC12 = _resolving.Resolve<ITestC12>(c);
                var testC13 = _resolving.Resolve<ITestC13>(c);
                var testC14 = _resolving.Resolve<ITestC14>(c);

                var testC = new TestC24(testC10, testC11, testC12, testC13, testC14);

                return testC;
            });

            #endregion

            #region TestC3

            _registration.RegisterFactoryMethod<ITestC30, TestC30>(container, c =>
            {
                var testC20 = _resolving.Resolve<ITestC20>(c);
                var testC21 = _resolving.Resolve<ITestC21>(c);
                var testC22 = _resolving.Resolve<ITestC22>(c);
                var testC23 = _resolving.Resolve<ITestC23>(c);
                var testC24 = _resolving.Resolve<ITestC24>(c);

                var testC = new TestC30(testC20, testC21, testC22, testC23, testC24);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC31, TestC31>(container, c =>
            {
                var testC20 = _resolving.Resolve<ITestC20>(c);
                var testC21 = _resolving.Resolve<ITestC21>(c);
                var testC22 = _resolving.Resolve<ITestC22>(c);
                var testC23 = _resolving.Resolve<ITestC23>(c);
                var testC24 = _resolving.Resolve<ITestC24>(c);

                var testC = new TestC31(testC20, testC21, testC22, testC23, testC24);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC32, TestC32>(container, c =>
            {
                var testC20 = _resolving.Resolve<ITestC20>(c);
                var testC21 = _resolving.Resolve<ITestC21>(c);
                var testC22 = _resolving.Resolve<ITestC22>(c);
                var testC23 = _resolving.Resolve<ITestC23>(c);
                var testC24 = _resolving.Resolve<ITestC24>(c);

                var testC = new TestC32(testC20, testC21, testC22, testC23, testC24);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC33, TestC33>(container, c =>
            {
                var testC20 = _resolving.Resolve<ITestC20>(c);
                var testC21 = _resolving.Resolve<ITestC21>(c);
                var testC22 = _resolving.Resolve<ITestC22>(c);
                var testC23 = _resolving.Resolve<ITestC23>(c);
                var testC24 = _resolving.Resolve<ITestC24>(c);

                var testC = new TestC33(testC20, testC21, testC22, testC23, testC24);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC34, TestC34>(container, c =>
            {
                var testC20 = _resolving.Resolve<ITestC20>(c);
                var testC21 = _resolving.Resolve<ITestC21>(c);
                var testC22 = _resolving.Resolve<ITestC22>(c);
                var testC23 = _resolving.Resolve<ITestC23>(c);
                var testC24 = _resolving.Resolve<ITestC24>(c);

                var testC = new TestC34(testC20, testC21, testC22, testC23, testC24);

                return testC;
            });

            #endregion

            #region TestC4

            _registration.RegisterFactoryMethod<ITestC40, TestC40>(container, c =>
            {
                var testC30 = _resolving.Resolve<ITestC30>(c);
                var testC31 = _resolving.Resolve<ITestC31>(c);
                var testC32 = _resolving.Resolve<ITestC32>(c);
                var testC33 = _resolving.Resolve<ITestC33>(c);
                var testC34 = _resolving.Resolve<ITestC34>(c);

                var testC = new TestC40(testC30, testC31, testC32, testC33, testC34);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC41, TestC41>(container, c =>
            {
                var testC30 = _resolving.Resolve<ITestC30>(c);
                var testC31 = _resolving.Resolve<ITestC31>(c);
                var testC32 = _resolving.Resolve<ITestC32>(c);
                var testC33 = _resolving.Resolve<ITestC33>(c);
                var testC34 = _resolving.Resolve<ITestC34>(c);

                var testC = new TestC41(testC30, testC31, testC32, testC33, testC34);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC42, TestC42>(container, c =>
            {
                var testC30 = _resolving.Resolve<ITestC30>(c);
                var testC31 = _resolving.Resolve<ITestC31>(c);
                var testC32 = _resolving.Resolve<ITestC32>(c);
                var testC33 = _resolving.Resolve<ITestC33>(c);
                var testC34 = _resolving.Resolve<ITestC34>(c);

                var testC = new TestC42(testC30, testC31, testC32, testC33, testC34);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC43, TestC43>(container, c =>
            {
                var testC30 = _resolving.Resolve<ITestC30>(c);
                var testC31 = _resolving.Resolve<ITestC31>(c);
                var testC32 = _resolving.Resolve<ITestC32>(c);
                var testC33 = _resolving.Resolve<ITestC33>(c);
                var testC34 = _resolving.Resolve<ITestC34>(c);

                var testC = new TestC43(testC30, testC31, testC32, testC33, testC34);

                return testC;
            });
            _registration.RegisterFactoryMethod<ITestC44, TestC44>(container, c =>
            {
                var testC30 = _resolving.Resolve<ITestC30>(c);
                var testC31 = _resolving.Resolve<ITestC31>(c);
                var testC32 = _resolving.Resolve<ITestC32>(c);
                var testC33 = _resolving.Resolve<ITestC33>(c);
                var testC34 = _resolving.Resolve<ITestC34>(c);

                var testC = new TestC44(testC30, testC31, testC32, testC33, testC34);

                return testC;
            });

            #endregion

            _registration.RegisterFactoryMethod<ITestC, TestC>(container, c =>
            {
                var testC40 = _resolving.Resolve<ITestC40>(c);
                var testC41 = _resolving.Resolve<ITestC41>(c);
                var testC42 = _resolving.Resolve<ITestC42>(c);
                var testC43 = _resolving.Resolve<ITestC43>(c);
                var testC44 = _resolving.Resolve<ITestC44>(c);

                var testC = new TestC(testC40, testC41, testC42, testC43, testC44);

                return testC;
            });
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestC>(container, testCasesNumber);
        }
    }
}