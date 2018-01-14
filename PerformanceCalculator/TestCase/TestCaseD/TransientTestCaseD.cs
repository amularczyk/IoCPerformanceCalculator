using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseD
{
    public class TransientTestCaseD : TestCase
    {
        public TransientTestCaseD(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            _registration.RegisterTransient<ITestD00, TestD00>(container);
            _registration.RegisterTransient<ITestD01, TestD01>(container);
            _registration.RegisterTransient<ITestD02, TestD02>(container);
            _registration.RegisterTransient<ITestD03, TestD03>(container);
            _registration.RegisterTransient<ITestD04, TestD04>(container);
            _registration.RegisterTransient<ITestD05, TestD05>(container);
            _registration.RegisterTransient<ITestD06, TestD06>(container);
            _registration.RegisterTransient<ITestD07, TestD07>(container);
            _registration.RegisterTransient<ITestD08, TestD08>(container);
            _registration.RegisterTransient<ITestD09, TestD09>(container);

            _registration.RegisterTransient<ITestD10, TestD10>(container);
            _registration.RegisterTransient<ITestD11, TestD11>(container);
            _registration.RegisterTransient<ITestD12, TestD12>(container);
            _registration.RegisterTransient<ITestD13, TestD13>(container);
            _registration.RegisterTransient<ITestD14, TestD14>(container);
            _registration.RegisterTransient<ITestD15, TestD15>(container);
            _registration.RegisterTransient<ITestD16, TestD16>(container);
            _registration.RegisterTransient<ITestD17, TestD17>(container);
            _registration.RegisterTransient<ITestD18, TestD18>(container);
            _registration.RegisterTransient<ITestD19, TestD19>(container);

            _registration.RegisterTransient<ITestD20, TestD20>(container);
            _registration.RegisterTransient<ITestD21, TestD21>(container);
            _registration.RegisterTransient<ITestD22, TestD22>(container);
            _registration.RegisterTransient<ITestD23, TestD23>(container);
            _registration.RegisterTransient<ITestD24, TestD24>(container);
            _registration.RegisterTransient<ITestD25, TestD25>(container);
            _registration.RegisterTransient<ITestD26, TestD26>(container);
            _registration.RegisterTransient<ITestD27, TestD27>(container);
            _registration.RegisterTransient<ITestD28, TestD28>(container);
            _registration.RegisterTransient<ITestD29, TestD29>(container);

            _registration.RegisterTransient<ITestD30, TestD30>(container);
            _registration.RegisterTransient<ITestD31, TestD31>(container);
            _registration.RegisterTransient<ITestD32, TestD32>(container);
            _registration.RegisterTransient<ITestD33, TestD33>(container);
            _registration.RegisterTransient<ITestD34, TestD34>(container);
            _registration.RegisterTransient<ITestD35, TestD35>(container);
            _registration.RegisterTransient<ITestD36, TestD36>(container);
            _registration.RegisterTransient<ITestD37, TestD37>(container);
            _registration.RegisterTransient<ITestD38, TestD38>(container);
            _registration.RegisterTransient<ITestD39, TestD39>(container);

            _registration.RegisterTransient<ITestD40, TestD40>(container);
            _registration.RegisterTransient<ITestD41, TestD41>(container);
            _registration.RegisterTransient<ITestD42, TestD42>(container);
            _registration.RegisterTransient<ITestD43, TestD43>(container);
            _registration.RegisterTransient<ITestD44, TestD44>(container);
            _registration.RegisterTransient<ITestD45, TestD45>(container);
            _registration.RegisterTransient<ITestD46, TestD46>(container);
            _registration.RegisterTransient<ITestD47, TestD47>(container);
            _registration.RegisterTransient<ITestD48, TestD48>(container);
            _registration.RegisterTransient<ITestD49, TestD49>(container);

            _registration.RegisterTransient<ITestD, TestD>(container);
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestD>(container, testCasesNumber);
        }
    }
}