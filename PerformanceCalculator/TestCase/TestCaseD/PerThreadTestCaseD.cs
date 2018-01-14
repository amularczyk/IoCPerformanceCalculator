using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseD
{
    public class PerThreadTestCaseD : TestCase
    {
        public PerThreadTestCaseD(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            _registration.RegisterPerThread<ITestD00, TestD00>(container);
            _registration.RegisterPerThread<ITestD01, TestD01>(container);
            _registration.RegisterPerThread<ITestD02, TestD02>(container);
            _registration.RegisterPerThread<ITestD03, TestD03>(container);
            _registration.RegisterPerThread<ITestD04, TestD04>(container);
            _registration.RegisterPerThread<ITestD05, TestD05>(container);
            _registration.RegisterPerThread<ITestD06, TestD06>(container);
            _registration.RegisterPerThread<ITestD07, TestD07>(container);
            _registration.RegisterPerThread<ITestD08, TestD08>(container);
            _registration.RegisterPerThread<ITestD09, TestD09>(container);

            _registration.RegisterPerThread<ITestD10, TestD10>(container);
            _registration.RegisterPerThread<ITestD11, TestD11>(container);
            _registration.RegisterPerThread<ITestD12, TestD12>(container);
            _registration.RegisterPerThread<ITestD13, TestD13>(container);
            _registration.RegisterPerThread<ITestD14, TestD14>(container);
            _registration.RegisterPerThread<ITestD15, TestD15>(container);
            _registration.RegisterPerThread<ITestD16, TestD16>(container);
            _registration.RegisterPerThread<ITestD17, TestD17>(container);
            _registration.RegisterPerThread<ITestD18, TestD18>(container);
            _registration.RegisterPerThread<ITestD19, TestD19>(container);

            _registration.RegisterPerThread<ITestD20, TestD20>(container);
            _registration.RegisterPerThread<ITestD21, TestD21>(container);
            _registration.RegisterPerThread<ITestD22, TestD22>(container);
            _registration.RegisterPerThread<ITestD23, TestD23>(container);
            _registration.RegisterPerThread<ITestD24, TestD24>(container);
            _registration.RegisterPerThread<ITestD25, TestD25>(container);
            _registration.RegisterPerThread<ITestD26, TestD26>(container);
            _registration.RegisterPerThread<ITestD27, TestD27>(container);
            _registration.RegisterPerThread<ITestD28, TestD28>(container);
            _registration.RegisterPerThread<ITestD29, TestD29>(container);

            _registration.RegisterPerThread<ITestD30, TestD30>(container);
            _registration.RegisterPerThread<ITestD31, TestD31>(container);
            _registration.RegisterPerThread<ITestD32, TestD32>(container);
            _registration.RegisterPerThread<ITestD33, TestD33>(container);
            _registration.RegisterPerThread<ITestD34, TestD34>(container);
            _registration.RegisterPerThread<ITestD35, TestD35>(container);
            _registration.RegisterPerThread<ITestD36, TestD36>(container);
            _registration.RegisterPerThread<ITestD37, TestD37>(container);
            _registration.RegisterPerThread<ITestD38, TestD38>(container);
            _registration.RegisterPerThread<ITestD39, TestD39>(container);

            _registration.RegisterPerThread<ITestD40, TestD40>(container);
            _registration.RegisterPerThread<ITestD41, TestD41>(container);
            _registration.RegisterPerThread<ITestD42, TestD42>(container);
            _registration.RegisterPerThread<ITestD43, TestD43>(container);
            _registration.RegisterPerThread<ITestD44, TestD44>(container);
            _registration.RegisterPerThread<ITestD45, TestD45>(container);
            _registration.RegisterPerThread<ITestD46, TestD46>(container);
            _registration.RegisterPerThread<ITestD47, TestD47>(container);
            _registration.RegisterPerThread<ITestD48, TestD48>(container);
            _registration.RegisterPerThread<ITestD49, TestD49>(container);

            _registration.RegisterPerThread<ITestD, TestD>(container);
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestD>(container, testCasesNumber);
        }
    }
}