using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseD
{
    public class FactoryMethodTestCaseD : TestCase
    {
        public FactoryMethodTestCaseD(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            #region TestD0

            _registration.RegisterFactoryMethod<ITestD00, TestD00>(container, c =>
            {
                var testD = new TestD00();

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD01, TestD01>(container, c =>
            {
                var testD = new TestD01();

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD02, TestD02>(container, c =>
            {
                var testD = new TestD02();

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD03, TestD03>(container, c =>
            {
                var testD = new TestD03();

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD04, TestD04>(container, c =>
            {
                var testD = new TestD04();

                return testD;
            });

            _registration.RegisterFactoryMethod<ITestD05, TestD05>(container, c =>
            {
                var testD = new TestD05();

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD06, TestD06>(container, c =>
            {
                var testD = new TestD06();

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD07, TestD07>(container, c =>
            {
                var testD = new TestD07();

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD08, TestD08>(container, c =>
            {
                var testD = new TestD08();

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD09, TestD09>(container, c =>
            {
                var testD = new TestD09();

                return testD;
            });

            #endregion


            #region TestD1

            _registration.RegisterFactoryMethod<ITestD10, TestD10>(container, c =>
            {
                var testD00 = _resolving.Resolve<ITestD00>(c);
                var testD01 = _resolving.Resolve<ITestD01>(c);
                var testD02 = _resolving.Resolve<ITestD02>(c);
                var testD03 = _resolving.Resolve<ITestD03>(c);
                var testD04 = _resolving.Resolve<ITestD04>(c);
                var testD05 = _resolving.Resolve<ITestD05>(c);
                var testD06 = _resolving.Resolve<ITestD06>(c);
                var testD07 = _resolving.Resolve<ITestD07>(c);
                var testD08 = _resolving.Resolve<ITestD08>(c);
                var testD09 = _resolving.Resolve<ITestD09>(c);

                var testD = new TestD10(testD00, testD01, testD02, testD03, testD04, testD05, testD06, testD07,
                    testD08, testD09);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD11, TestD11>(container, c =>
            {
                var testD00 = _resolving.Resolve<ITestD00>(c);
                var testD01 = _resolving.Resolve<ITestD01>(c);
                var testD02 = _resolving.Resolve<ITestD02>(c);
                var testD03 = _resolving.Resolve<ITestD03>(c);
                var testD04 = _resolving.Resolve<ITestD04>(c);
                var testD05 = _resolving.Resolve<ITestD05>(c);
                var testD06 = _resolving.Resolve<ITestD06>(c);
                var testD07 = _resolving.Resolve<ITestD07>(c);
                var testD08 = _resolving.Resolve<ITestD08>(c);
                var testD09 = _resolving.Resolve<ITestD09>(c);

                var testD = new TestD11(testD00, testD01, testD02, testD03, testD04, testD05, testD06, testD07,
                    testD08, testD09);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD12, TestD12>(container, c =>
            {
                var testD00 = _resolving.Resolve<ITestD00>(c);
                var testD01 = _resolving.Resolve<ITestD01>(c);
                var testD02 = _resolving.Resolve<ITestD02>(c);
                var testD03 = _resolving.Resolve<ITestD03>(c);
                var testD04 = _resolving.Resolve<ITestD04>(c);
                var testD05 = _resolving.Resolve<ITestD05>(c);
                var testD06 = _resolving.Resolve<ITestD06>(c);
                var testD07 = _resolving.Resolve<ITestD07>(c);
                var testD08 = _resolving.Resolve<ITestD08>(c);
                var testD09 = _resolving.Resolve<ITestD09>(c);

                var testD = new TestD12(testD00, testD01, testD02, testD03, testD04, testD05, testD06, testD07,
                    testD08, testD09);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD13, TestD13>(container, c =>
            {
                var testD00 = _resolving.Resolve<ITestD00>(c);
                var testD01 = _resolving.Resolve<ITestD01>(c);
                var testD02 = _resolving.Resolve<ITestD02>(c);
                var testD03 = _resolving.Resolve<ITestD03>(c);
                var testD04 = _resolving.Resolve<ITestD04>(c);
                var testD05 = _resolving.Resolve<ITestD05>(c);
                var testD06 = _resolving.Resolve<ITestD06>(c);
                var testD07 = _resolving.Resolve<ITestD07>(c);
                var testD08 = _resolving.Resolve<ITestD08>(c);
                var testD09 = _resolving.Resolve<ITestD09>(c);

                var testD = new TestD13(testD00, testD01, testD02, testD03, testD04, testD05, testD06, testD07,
                    testD08, testD09);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD14, TestD14>(container, c =>
            {
                var testD00 = _resolving.Resolve<ITestD00>(c);
                var testD01 = _resolving.Resolve<ITestD01>(c);
                var testD02 = _resolving.Resolve<ITestD02>(c);
                var testD03 = _resolving.Resolve<ITestD03>(c);
                var testD04 = _resolving.Resolve<ITestD04>(c);
                var testD05 = _resolving.Resolve<ITestD05>(c);
                var testD06 = _resolving.Resolve<ITestD06>(c);
                var testD07 = _resolving.Resolve<ITestD07>(c);
                var testD08 = _resolving.Resolve<ITestD08>(c);
                var testD09 = _resolving.Resolve<ITestD09>(c);

                var testD = new TestD14(testD00, testD01, testD02, testD03, testD04, testD05, testD06, testD07,
                    testD08, testD09);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD15, TestD15>(container, c =>
            {
                var testD00 = _resolving.Resolve<ITestD00>(c);
                var testD01 = _resolving.Resolve<ITestD01>(c);
                var testD02 = _resolving.Resolve<ITestD02>(c);
                var testD03 = _resolving.Resolve<ITestD03>(c);
                var testD04 = _resolving.Resolve<ITestD04>(c);
                var testD05 = _resolving.Resolve<ITestD05>(c);
                var testD06 = _resolving.Resolve<ITestD06>(c);
                var testD07 = _resolving.Resolve<ITestD07>(c);
                var testD08 = _resolving.Resolve<ITestD08>(c);
                var testD09 = _resolving.Resolve<ITestD09>(c);

                var testD = new TestD15(testD00, testD01, testD02, testD03, testD04, testD05, testD06, testD07,
                    testD08, testD09);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD16, TestD16>(container, c =>
            {
                var testD00 = _resolving.Resolve<ITestD00>(c);
                var testD01 = _resolving.Resolve<ITestD01>(c);
                var testD02 = _resolving.Resolve<ITestD02>(c);
                var testD03 = _resolving.Resolve<ITestD03>(c);
                var testD04 = _resolving.Resolve<ITestD04>(c);
                var testD05 = _resolving.Resolve<ITestD05>(c);
                var testD06 = _resolving.Resolve<ITestD06>(c);
                var testD07 = _resolving.Resolve<ITestD07>(c);
                var testD08 = _resolving.Resolve<ITestD08>(c);
                var testD09 = _resolving.Resolve<ITestD09>(c);

                var testD = new TestD16(testD00, testD01, testD02, testD03, testD04, testD05, testD06, testD07,
                    testD08, testD09);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD17, TestD17>(container, c =>
            {
                var testD00 = _resolving.Resolve<ITestD00>(c);
                var testD01 = _resolving.Resolve<ITestD01>(c);
                var testD02 = _resolving.Resolve<ITestD02>(c);
                var testD03 = _resolving.Resolve<ITestD03>(c);
                var testD04 = _resolving.Resolve<ITestD04>(c);
                var testD05 = _resolving.Resolve<ITestD05>(c);
                var testD06 = _resolving.Resolve<ITestD06>(c);
                var testD07 = _resolving.Resolve<ITestD07>(c);
                var testD08 = _resolving.Resolve<ITestD08>(c);
                var testD09 = _resolving.Resolve<ITestD09>(c);

                var testD = new TestD17(testD00, testD01, testD02, testD03, testD04, testD05, testD06, testD07,
                    testD08, testD09);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD18, TestD18>(container, c =>
            {
                var testD00 = _resolving.Resolve<ITestD00>(c);
                var testD01 = _resolving.Resolve<ITestD01>(c);
                var testD02 = _resolving.Resolve<ITestD02>(c);
                var testD03 = _resolving.Resolve<ITestD03>(c);
                var testD04 = _resolving.Resolve<ITestD04>(c);
                var testD05 = _resolving.Resolve<ITestD05>(c);
                var testD06 = _resolving.Resolve<ITestD06>(c);
                var testD07 = _resolving.Resolve<ITestD07>(c);
                var testD08 = _resolving.Resolve<ITestD08>(c);
                var testD09 = _resolving.Resolve<ITestD09>(c);

                var testD = new TestD18(testD00, testD01, testD02, testD03, testD04, testD05, testD06, testD07,
                    testD08, testD09);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD19, TestD19>(container, c =>
            {
                var testD00 = _resolving.Resolve<ITestD00>(c);
                var testD01 = _resolving.Resolve<ITestD01>(c);
                var testD02 = _resolving.Resolve<ITestD02>(c);
                var testD03 = _resolving.Resolve<ITestD03>(c);
                var testD04 = _resolving.Resolve<ITestD04>(c);
                var testD05 = _resolving.Resolve<ITestD05>(c);
                var testD06 = _resolving.Resolve<ITestD06>(c);
                var testD07 = _resolving.Resolve<ITestD07>(c);
                var testD08 = _resolving.Resolve<ITestD08>(c);
                var testD09 = _resolving.Resolve<ITestD09>(c);

                var testD = new TestD19(testD00, testD01, testD02, testD03, testD04, testD05, testD06, testD07,
                    testD08, testD09);

                return testD;
            });

            #endregion


            #region TestD2

            _registration.RegisterFactoryMethod<ITestD20, TestD20>(container, c =>
            {
                var testD10 = _resolving.Resolve<ITestD10>(c);
                var testD11 = _resolving.Resolve<ITestD11>(c);
                var testD12 = _resolving.Resolve<ITestD12>(c);
                var testD13 = _resolving.Resolve<ITestD13>(c);
                var testD14 = _resolving.Resolve<ITestD14>(c);
                var testD15 = _resolving.Resolve<ITestD15>(c);
                var testD16 = _resolving.Resolve<ITestD16>(c);
                var testD17 = _resolving.Resolve<ITestD17>(c);
                var testD18 = _resolving.Resolve<ITestD18>(c);
                var testD19 = _resolving.Resolve<ITestD19>(c);

                var testD = new TestD20(testD10, testD11, testD12, testD13, testD14, testD15, testD16, testD17,
                    testD18, testD19);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD21, TestD21>(container, c =>
            {
                var testD10 = _resolving.Resolve<ITestD10>(c);
                var testD11 = _resolving.Resolve<ITestD11>(c);
                var testD12 = _resolving.Resolve<ITestD12>(c);
                var testD13 = _resolving.Resolve<ITestD13>(c);
                var testD14 = _resolving.Resolve<ITestD14>(c);
                var testD15 = _resolving.Resolve<ITestD15>(c);
                var testD16 = _resolving.Resolve<ITestD16>(c);
                var testD17 = _resolving.Resolve<ITestD17>(c);
                var testD18 = _resolving.Resolve<ITestD18>(c);
                var testD19 = _resolving.Resolve<ITestD19>(c);

                var testD = new TestD21(testD10, testD11, testD12, testD13, testD14, testD15, testD16, testD17,
                    testD18, testD19);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD22, TestD22>(container, c =>
            {
                var testD10 = _resolving.Resolve<ITestD10>(c);
                var testD11 = _resolving.Resolve<ITestD11>(c);
                var testD12 = _resolving.Resolve<ITestD12>(c);
                var testD13 = _resolving.Resolve<ITestD13>(c);
                var testD14 = _resolving.Resolve<ITestD14>(c);
                var testD15 = _resolving.Resolve<ITestD15>(c);
                var testD16 = _resolving.Resolve<ITestD16>(c);
                var testD17 = _resolving.Resolve<ITestD17>(c);
                var testD18 = _resolving.Resolve<ITestD18>(c);
                var testD19 = _resolving.Resolve<ITestD19>(c);

                var testD = new TestD22(testD10, testD11, testD12, testD13, testD14, testD15, testD16, testD17,
                    testD18, testD19);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD23, TestD23>(container, c =>
            {
                var testD10 = _resolving.Resolve<ITestD10>(c);
                var testD11 = _resolving.Resolve<ITestD11>(c);
                var testD12 = _resolving.Resolve<ITestD12>(c);
                var testD13 = _resolving.Resolve<ITestD13>(c);
                var testD14 = _resolving.Resolve<ITestD14>(c);
                var testD15 = _resolving.Resolve<ITestD15>(c);
                var testD16 = _resolving.Resolve<ITestD16>(c);
                var testD17 = _resolving.Resolve<ITestD17>(c);
                var testD18 = _resolving.Resolve<ITestD18>(c);
                var testD19 = _resolving.Resolve<ITestD19>(c);

                var testD = new TestD23(testD10, testD11, testD12, testD13, testD14, testD15, testD16, testD17,
                    testD18, testD19);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD24, TestD24>(container, c =>
            {
                var testD10 = _resolving.Resolve<ITestD10>(c);
                var testD11 = _resolving.Resolve<ITestD11>(c);
                var testD12 = _resolving.Resolve<ITestD12>(c);
                var testD13 = _resolving.Resolve<ITestD13>(c);
                var testD14 = _resolving.Resolve<ITestD14>(c);
                var testD15 = _resolving.Resolve<ITestD15>(c);
                var testD16 = _resolving.Resolve<ITestD16>(c);
                var testD17 = _resolving.Resolve<ITestD17>(c);
                var testD18 = _resolving.Resolve<ITestD18>(c);
                var testD19 = _resolving.Resolve<ITestD19>(c);

                var testD = new TestD24(testD10, testD11, testD12, testD13, testD14, testD15, testD16, testD17,
                    testD18, testD19);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD25, TestD25>(container, c =>
            {
                var testD10 = _resolving.Resolve<ITestD10>(c);
                var testD11 = _resolving.Resolve<ITestD11>(c);
                var testD12 = _resolving.Resolve<ITestD12>(c);
                var testD13 = _resolving.Resolve<ITestD13>(c);
                var testD14 = _resolving.Resolve<ITestD14>(c);
                var testD15 = _resolving.Resolve<ITestD15>(c);
                var testD16 = _resolving.Resolve<ITestD16>(c);
                var testD17 = _resolving.Resolve<ITestD17>(c);
                var testD18 = _resolving.Resolve<ITestD18>(c);
                var testD19 = _resolving.Resolve<ITestD19>(c);

                var testD = new TestD25(testD10, testD11, testD12, testD13, testD14, testD15, testD16, testD17,
                    testD18, testD19);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD26, TestD26>(container, c =>
            {
                var testD10 = _resolving.Resolve<ITestD10>(c);
                var testD11 = _resolving.Resolve<ITestD11>(c);
                var testD12 = _resolving.Resolve<ITestD12>(c);
                var testD13 = _resolving.Resolve<ITestD13>(c);
                var testD14 = _resolving.Resolve<ITestD14>(c);
                var testD15 = _resolving.Resolve<ITestD15>(c);
                var testD16 = _resolving.Resolve<ITestD16>(c);
                var testD17 = _resolving.Resolve<ITestD17>(c);
                var testD18 = _resolving.Resolve<ITestD18>(c);
                var testD19 = _resolving.Resolve<ITestD19>(c);

                var testD = new TestD26(testD10, testD11, testD12, testD13, testD14, testD15, testD16, testD17,
                    testD18, testD19);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD27, TestD27>(container, c =>
            {
                var testD10 = _resolving.Resolve<ITestD10>(c);
                var testD11 = _resolving.Resolve<ITestD11>(c);
                var testD12 = _resolving.Resolve<ITestD12>(c);
                var testD13 = _resolving.Resolve<ITestD13>(c);
                var testD14 = _resolving.Resolve<ITestD14>(c);
                var testD15 = _resolving.Resolve<ITestD15>(c);
                var testD16 = _resolving.Resolve<ITestD16>(c);
                var testD17 = _resolving.Resolve<ITestD17>(c);
                var testD18 = _resolving.Resolve<ITestD18>(c);
                var testD19 = _resolving.Resolve<ITestD19>(c);

                var testD = new TestD27(testD10, testD11, testD12, testD13, testD14, testD15, testD16, testD17,
                    testD18, testD19);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD28, TestD28>(container, c =>
            {
                var testD10 = _resolving.Resolve<ITestD10>(c);
                var testD11 = _resolving.Resolve<ITestD11>(c);
                var testD12 = _resolving.Resolve<ITestD12>(c);
                var testD13 = _resolving.Resolve<ITestD13>(c);
                var testD14 = _resolving.Resolve<ITestD14>(c);
                var testD15 = _resolving.Resolve<ITestD15>(c);
                var testD16 = _resolving.Resolve<ITestD16>(c);
                var testD17 = _resolving.Resolve<ITestD17>(c);
                var testD18 = _resolving.Resolve<ITestD18>(c);
                var testD19 = _resolving.Resolve<ITestD19>(c);

                var testD = new TestD28(testD10, testD11, testD12, testD13, testD14, testD15, testD16, testD17,
                    testD18, testD19);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD29, TestD29>(container, c =>
            {
                var testD10 = _resolving.Resolve<ITestD10>(c);
                var testD11 = _resolving.Resolve<ITestD11>(c);
                var testD12 = _resolving.Resolve<ITestD12>(c);
                var testD13 = _resolving.Resolve<ITestD13>(c);
                var testD14 = _resolving.Resolve<ITestD14>(c);
                var testD15 = _resolving.Resolve<ITestD15>(c);
                var testD16 = _resolving.Resolve<ITestD16>(c);
                var testD17 = _resolving.Resolve<ITestD17>(c);
                var testD18 = _resolving.Resolve<ITestD18>(c);
                var testD19 = _resolving.Resolve<ITestD19>(c);

                var testD = new TestD29(testD10, testD11, testD12, testD13, testD14, testD15, testD16, testD17,
                    testD18, testD19);

                return testD;
            });

            #endregion


            #region TestD3

            _registration.RegisterFactoryMethod<ITestD30, TestD30>(container, c =>
            {
                var testD20 = _resolving.Resolve<ITestD20>(c);
                var testD21 = _resolving.Resolve<ITestD21>(c);
                var testD22 = _resolving.Resolve<ITestD22>(c);
                var testD23 = _resolving.Resolve<ITestD23>(c);
                var testD24 = _resolving.Resolve<ITestD24>(c);
                var testD25 = _resolving.Resolve<ITestD25>(c);
                var testD26 = _resolving.Resolve<ITestD26>(c);
                var testD27 = _resolving.Resolve<ITestD27>(c);
                var testD28 = _resolving.Resolve<ITestD28>(c);
                var testD29 = _resolving.Resolve<ITestD29>(c);

                var testD = new TestD30(testD20, testD21, testD22, testD23, testD24, testD25, testD26, testD27,
                    testD28, testD29);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD31, TestD31>(container, c =>
            {
                var testD20 = _resolving.Resolve<ITestD20>(c);
                var testD21 = _resolving.Resolve<ITestD21>(c);
                var testD22 = _resolving.Resolve<ITestD22>(c);
                var testD23 = _resolving.Resolve<ITestD23>(c);
                var testD24 = _resolving.Resolve<ITestD24>(c);
                var testD25 = _resolving.Resolve<ITestD25>(c);
                var testD26 = _resolving.Resolve<ITestD26>(c);
                var testD27 = _resolving.Resolve<ITestD27>(c);
                var testD28 = _resolving.Resolve<ITestD28>(c);
                var testD29 = _resolving.Resolve<ITestD29>(c);

                var testD = new TestD31(testD20, testD21, testD22, testD23, testD24, testD25, testD26, testD27,
                    testD28, testD29);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD32, TestD32>(container, c =>
            {
                var testD20 = _resolving.Resolve<ITestD20>(c);
                var testD21 = _resolving.Resolve<ITestD21>(c);
                var testD22 = _resolving.Resolve<ITestD22>(c);
                var testD23 = _resolving.Resolve<ITestD23>(c);
                var testD24 = _resolving.Resolve<ITestD24>(c);
                var testD25 = _resolving.Resolve<ITestD25>(c);
                var testD26 = _resolving.Resolve<ITestD26>(c);
                var testD27 = _resolving.Resolve<ITestD27>(c);
                var testD28 = _resolving.Resolve<ITestD28>(c);
                var testD29 = _resolving.Resolve<ITestD29>(c);

                var testD = new TestD32(testD20, testD21, testD22, testD23, testD24, testD25, testD26, testD27,
                    testD28, testD29);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD33, TestD33>(container, c =>
            {
                var testD20 = _resolving.Resolve<ITestD20>(c);
                var testD21 = _resolving.Resolve<ITestD21>(c);
                var testD22 = _resolving.Resolve<ITestD22>(c);
                var testD23 = _resolving.Resolve<ITestD23>(c);
                var testD24 = _resolving.Resolve<ITestD24>(c);
                var testD25 = _resolving.Resolve<ITestD25>(c);
                var testD26 = _resolving.Resolve<ITestD26>(c);
                var testD27 = _resolving.Resolve<ITestD27>(c);
                var testD28 = _resolving.Resolve<ITestD28>(c);
                var testD29 = _resolving.Resolve<ITestD29>(c);

                var testD = new TestD33(testD20, testD21, testD22, testD23, testD24, testD25, testD26, testD27,
                    testD28, testD29);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD34, TestD34>(container, c =>
            {
                var testD20 = _resolving.Resolve<ITestD20>(c);
                var testD21 = _resolving.Resolve<ITestD21>(c);
                var testD22 = _resolving.Resolve<ITestD22>(c);
                var testD23 = _resolving.Resolve<ITestD23>(c);
                var testD24 = _resolving.Resolve<ITestD24>(c);
                var testD25 = _resolving.Resolve<ITestD25>(c);
                var testD26 = _resolving.Resolve<ITestD26>(c);
                var testD27 = _resolving.Resolve<ITestD27>(c);
                var testD28 = _resolving.Resolve<ITestD28>(c);
                var testD29 = _resolving.Resolve<ITestD29>(c);

                var testD = new TestD34(testD20, testD21, testD22, testD23, testD24, testD25, testD26, testD27,
                    testD28, testD29);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD35, TestD35>(container, c =>
            {
                var testD20 = _resolving.Resolve<ITestD20>(c);
                var testD21 = _resolving.Resolve<ITestD21>(c);
                var testD22 = _resolving.Resolve<ITestD22>(c);
                var testD23 = _resolving.Resolve<ITestD23>(c);
                var testD24 = _resolving.Resolve<ITestD24>(c);
                var testD25 = _resolving.Resolve<ITestD25>(c);
                var testD26 = _resolving.Resolve<ITestD26>(c);
                var testD27 = _resolving.Resolve<ITestD27>(c);
                var testD28 = _resolving.Resolve<ITestD28>(c);
                var testD29 = _resolving.Resolve<ITestD29>(c);

                var testD = new TestD35(testD20, testD21, testD22, testD23, testD24, testD25, testD26, testD27,
                    testD28, testD29);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD36, TestD36>(container, c =>
            {
                var testD20 = _resolving.Resolve<ITestD20>(c);
                var testD21 = _resolving.Resolve<ITestD21>(c);
                var testD22 = _resolving.Resolve<ITestD22>(c);
                var testD23 = _resolving.Resolve<ITestD23>(c);
                var testD24 = _resolving.Resolve<ITestD24>(c);
                var testD25 = _resolving.Resolve<ITestD25>(c);
                var testD26 = _resolving.Resolve<ITestD26>(c);
                var testD27 = _resolving.Resolve<ITestD27>(c);
                var testD28 = _resolving.Resolve<ITestD28>(c);
                var testD29 = _resolving.Resolve<ITestD29>(c);

                var testD = new TestD36(testD20, testD21, testD22, testD23, testD24, testD25, testD26, testD27,
                    testD28, testD29);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD37, TestD37>(container, c =>
            {
                var testD20 = _resolving.Resolve<ITestD20>(c);
                var testD21 = _resolving.Resolve<ITestD21>(c);
                var testD22 = _resolving.Resolve<ITestD22>(c);
                var testD23 = _resolving.Resolve<ITestD23>(c);
                var testD24 = _resolving.Resolve<ITestD24>(c);
                var testD25 = _resolving.Resolve<ITestD25>(c);
                var testD26 = _resolving.Resolve<ITestD26>(c);
                var testD27 = _resolving.Resolve<ITestD27>(c);
                var testD28 = _resolving.Resolve<ITestD28>(c);
                var testD29 = _resolving.Resolve<ITestD29>(c);

                var testD = new TestD37(testD20, testD21, testD22, testD23, testD24, testD25, testD26, testD27,
                    testD28, testD29);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD38, TestD38>(container, c =>
            {
                var testD20 = _resolving.Resolve<ITestD20>(c);
                var testD21 = _resolving.Resolve<ITestD21>(c);
                var testD22 = _resolving.Resolve<ITestD22>(c);
                var testD23 = _resolving.Resolve<ITestD23>(c);
                var testD24 = _resolving.Resolve<ITestD24>(c);
                var testD25 = _resolving.Resolve<ITestD25>(c);
                var testD26 = _resolving.Resolve<ITestD26>(c);
                var testD27 = _resolving.Resolve<ITestD27>(c);
                var testD28 = _resolving.Resolve<ITestD28>(c);
                var testD29 = _resolving.Resolve<ITestD29>(c);

                var testD = new TestD38(testD20, testD21, testD22, testD23, testD24, testD25, testD26, testD27,
                    testD28, testD29);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD39, TestD39>(container, c =>
            {
                var testD20 = _resolving.Resolve<ITestD20>(c);
                var testD21 = _resolving.Resolve<ITestD21>(c);
                var testD22 = _resolving.Resolve<ITestD22>(c);
                var testD23 = _resolving.Resolve<ITestD23>(c);
                var testD24 = _resolving.Resolve<ITestD24>(c);
                var testD25 = _resolving.Resolve<ITestD25>(c);
                var testD26 = _resolving.Resolve<ITestD26>(c);
                var testD27 = _resolving.Resolve<ITestD27>(c);
                var testD28 = _resolving.Resolve<ITestD28>(c);
                var testD29 = _resolving.Resolve<ITestD29>(c);

                var testD = new TestD39(testD20, testD21, testD22, testD23, testD24, testD25, testD26, testD27,
                    testD28, testD29);

                return testD;
            });

            #endregion


            #region TestD4

            _registration.RegisterFactoryMethod<ITestD40, TestD40>(container, c =>
            {
                var testD30 = _resolving.Resolve<ITestD30>(c);
                var testD31 = _resolving.Resolve<ITestD31>(c);
                var testD32 = _resolving.Resolve<ITestD32>(c);
                var testD33 = _resolving.Resolve<ITestD33>(c);
                var testD34 = _resolving.Resolve<ITestD34>(c);
                var testD35 = _resolving.Resolve<ITestD35>(c);
                var testD36 = _resolving.Resolve<ITestD36>(c);
                var testD37 = _resolving.Resolve<ITestD37>(c);
                var testD38 = _resolving.Resolve<ITestD38>(c);
                var testD39 = _resolving.Resolve<ITestD39>(c);

                var testD = new TestD40(testD30, testD31, testD32, testD33, testD34, testD35, testD36, testD37,
                    testD38, testD39);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD41, TestD41>(container, c =>
            {
                var testD30 = _resolving.Resolve<ITestD30>(c);
                var testD31 = _resolving.Resolve<ITestD31>(c);
                var testD32 = _resolving.Resolve<ITestD32>(c);
                var testD33 = _resolving.Resolve<ITestD33>(c);
                var testD34 = _resolving.Resolve<ITestD34>(c);
                var testD35 = _resolving.Resolve<ITestD35>(c);
                var testD36 = _resolving.Resolve<ITestD36>(c);
                var testD37 = _resolving.Resolve<ITestD37>(c);
                var testD38 = _resolving.Resolve<ITestD38>(c);
                var testD39 = _resolving.Resolve<ITestD39>(c);

                var testD = new TestD41(testD30, testD31, testD32, testD33, testD34, testD35, testD36, testD37,
                    testD38, testD39);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD42, TestD42>(container, c =>
            {
                var testD30 = _resolving.Resolve<ITestD30>(c);
                var testD31 = _resolving.Resolve<ITestD31>(c);
                var testD32 = _resolving.Resolve<ITestD32>(c);
                var testD33 = _resolving.Resolve<ITestD33>(c);
                var testD34 = _resolving.Resolve<ITestD34>(c);
                var testD35 = _resolving.Resolve<ITestD35>(c);
                var testD36 = _resolving.Resolve<ITestD36>(c);
                var testD37 = _resolving.Resolve<ITestD37>(c);
                var testD38 = _resolving.Resolve<ITestD38>(c);
                var testD39 = _resolving.Resolve<ITestD39>(c);

                var testD = new TestD42(testD30, testD31, testD32, testD33, testD34, testD35, testD36, testD37,
                    testD38, testD39);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD43, TestD43>(container, c =>
            {
                var testD30 = _resolving.Resolve<ITestD30>(c);
                var testD31 = _resolving.Resolve<ITestD31>(c);
                var testD32 = _resolving.Resolve<ITestD32>(c);
                var testD33 = _resolving.Resolve<ITestD33>(c);
                var testD34 = _resolving.Resolve<ITestD34>(c);
                var testD35 = _resolving.Resolve<ITestD35>(c);
                var testD36 = _resolving.Resolve<ITestD36>(c);
                var testD37 = _resolving.Resolve<ITestD37>(c);
                var testD38 = _resolving.Resolve<ITestD38>(c);
                var testD39 = _resolving.Resolve<ITestD39>(c);

                var testD = new TestD43(testD30, testD31, testD32, testD33, testD34, testD35, testD36, testD37,
                    testD38, testD39);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD44, TestD44>(container, c =>
            {
                var testD30 = _resolving.Resolve<ITestD30>(c);
                var testD31 = _resolving.Resolve<ITestD31>(c);
                var testD32 = _resolving.Resolve<ITestD32>(c);
                var testD33 = _resolving.Resolve<ITestD33>(c);
                var testD34 = _resolving.Resolve<ITestD34>(c);
                var testD35 = _resolving.Resolve<ITestD35>(c);
                var testD36 = _resolving.Resolve<ITestD36>(c);
                var testD37 = _resolving.Resolve<ITestD37>(c);
                var testD38 = _resolving.Resolve<ITestD38>(c);
                var testD39 = _resolving.Resolve<ITestD39>(c);

                var testD = new TestD44(testD30, testD31, testD32, testD33, testD34, testD35, testD36, testD37,
                    testD38, testD39);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD45, TestD45>(container, c =>
            {
                var testD30 = _resolving.Resolve<ITestD30>(c);
                var testD31 = _resolving.Resolve<ITestD31>(c);
                var testD32 = _resolving.Resolve<ITestD32>(c);
                var testD33 = _resolving.Resolve<ITestD33>(c);
                var testD34 = _resolving.Resolve<ITestD34>(c);
                var testD35 = _resolving.Resolve<ITestD35>(c);
                var testD36 = _resolving.Resolve<ITestD36>(c);
                var testD37 = _resolving.Resolve<ITestD37>(c);
                var testD38 = _resolving.Resolve<ITestD38>(c);
                var testD39 = _resolving.Resolve<ITestD39>(c);

                var testD = new TestD45(testD30, testD31, testD32, testD33, testD34, testD35, testD36, testD37,
                    testD38, testD39);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD46, TestD46>(container, c =>
            {
                var testD30 = _resolving.Resolve<ITestD30>(c);
                var testD31 = _resolving.Resolve<ITestD31>(c);
                var testD32 = _resolving.Resolve<ITestD32>(c);
                var testD33 = _resolving.Resolve<ITestD33>(c);
                var testD34 = _resolving.Resolve<ITestD34>(c);
                var testD35 = _resolving.Resolve<ITestD35>(c);
                var testD36 = _resolving.Resolve<ITestD36>(c);
                var testD37 = _resolving.Resolve<ITestD37>(c);
                var testD38 = _resolving.Resolve<ITestD38>(c);
                var testD39 = _resolving.Resolve<ITestD39>(c);

                var testD = new TestD46(testD30, testD31, testD32, testD33, testD34, testD35, testD36, testD37,
                    testD38, testD39);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD47, TestD47>(container, c =>
            {
                var testD30 = _resolving.Resolve<ITestD30>(c);
                var testD31 = _resolving.Resolve<ITestD31>(c);
                var testD32 = _resolving.Resolve<ITestD32>(c);
                var testD33 = _resolving.Resolve<ITestD33>(c);
                var testD34 = _resolving.Resolve<ITestD34>(c);
                var testD35 = _resolving.Resolve<ITestD35>(c);
                var testD36 = _resolving.Resolve<ITestD36>(c);
                var testD37 = _resolving.Resolve<ITestD37>(c);
                var testD38 = _resolving.Resolve<ITestD38>(c);
                var testD39 = _resolving.Resolve<ITestD39>(c);

                var testD = new TestD47(testD30, testD31, testD32, testD33, testD34, testD35, testD36, testD37,
                    testD38, testD39);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD48, TestD48>(container, c =>
            {
                var testD30 = _resolving.Resolve<ITestD30>(c);
                var testD31 = _resolving.Resolve<ITestD31>(c);
                var testD32 = _resolving.Resolve<ITestD32>(c);
                var testD33 = _resolving.Resolve<ITestD33>(c);
                var testD34 = _resolving.Resolve<ITestD34>(c);
                var testD35 = _resolving.Resolve<ITestD35>(c);
                var testD36 = _resolving.Resolve<ITestD36>(c);
                var testD37 = _resolving.Resolve<ITestD37>(c);
                var testD38 = _resolving.Resolve<ITestD38>(c);
                var testD39 = _resolving.Resolve<ITestD39>(c);

                var testD = new TestD48(testD30, testD31, testD32, testD33, testD34, testD35, testD36, testD37,
                    testD38, testD39);

                return testD;
            });
            _registration.RegisterFactoryMethod<ITestD49, TestD49>(container, c =>
            {
                var testD30 = _resolving.Resolve<ITestD30>(c);
                var testD31 = _resolving.Resolve<ITestD31>(c);
                var testD32 = _resolving.Resolve<ITestD32>(c);
                var testD33 = _resolving.Resolve<ITestD33>(c);
                var testD34 = _resolving.Resolve<ITestD34>(c);
                var testD35 = _resolving.Resolve<ITestD35>(c);
                var testD36 = _resolving.Resolve<ITestD36>(c);
                var testD37 = _resolving.Resolve<ITestD37>(c);
                var testD38 = _resolving.Resolve<ITestD38>(c);
                var testD39 = _resolving.Resolve<ITestD39>(c);

                var testD = new TestD49(testD30, testD31, testD32, testD33, testD34, testD35, testD36, testD37,
                    testD38, testD39);

                return testD;
            });

            #endregion
            
            _registration.RegisterFactoryMethod<ITestD, TestD>(container, c =>
            {
                var testD40 = _resolving.Resolve<ITestD40>(c);
                var testD41 = _resolving.Resolve<ITestD41>(c);
                var testD42 = _resolving.Resolve<ITestD42>(c);
                var testD43 = _resolving.Resolve<ITestD43>(c);
                var testD44 = _resolving.Resolve<ITestD44>(c);
                var testD45 = _resolving.Resolve<ITestD45>(c);
                var testD46 = _resolving.Resolve<ITestD46>(c);
                var testD47 = _resolving.Resolve<ITestD47>(c);
                var testD48 = _resolving.Resolve<ITestD48>(c);
                var testD49 = _resolving.Resolve<ITestD49>(c);

                var testD = new TestD(testD40, testD41, testD42, testD43, testD44, testD45, testD46, testD47, testD48,
                    testD49);

                return testD;
            });
        }

        public override void Resolve(object container, int testDasesNumber)
        {
            _resolving.Resolve<ITestD>(container, testDasesNumber);
        }
    }
}