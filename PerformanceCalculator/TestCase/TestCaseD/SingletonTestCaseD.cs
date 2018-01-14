using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseD
{
    public class SingletonTestCaseD : TestCase
    {
        public SingletonTestCaseD(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            _registration.RegisterSingleton<ITestD00, TestD00>(container);
            _registration.RegisterSingleton<ITestD01, TestD01>(container);
            _registration.RegisterSingleton<ITestD02, TestD02>(container);
            _registration.RegisterSingleton<ITestD03, TestD03>(container);
            _registration.RegisterSingleton<ITestD04, TestD04>(container);
            _registration.RegisterSingleton<ITestD05, TestD05>(container);
            _registration.RegisterSingleton<ITestD06, TestD06>(container);
            _registration.RegisterSingleton<ITestD07, TestD07>(container);
            _registration.RegisterSingleton<ITestD08, TestD08>(container);
            _registration.RegisterSingleton<ITestD09, TestD09>(container);

            _registration.RegisterSingleton<ITestD10, TestD10>(container);
            _registration.RegisterSingleton<ITestD11, TestD11>(container);
            _registration.RegisterSingleton<ITestD12, TestD12>(container);
            _registration.RegisterSingleton<ITestD13, TestD13>(container);
            _registration.RegisterSingleton<ITestD14, TestD14>(container);
            _registration.RegisterSingleton<ITestD15, TestD15>(container);
            _registration.RegisterSingleton<ITestD16, TestD16>(container);
            _registration.RegisterSingleton<ITestD17, TestD17>(container);
            _registration.RegisterSingleton<ITestD18, TestD18>(container);
            _registration.RegisterSingleton<ITestD19, TestD19>(container);

            _registration.RegisterSingleton<ITestD20, TestD20>(container);
            _registration.RegisterSingleton<ITestD21, TestD21>(container);
            _registration.RegisterSingleton<ITestD22, TestD22>(container);
            _registration.RegisterSingleton<ITestD23, TestD23>(container);
            _registration.RegisterSingleton<ITestD24, TestD24>(container);
            _registration.RegisterSingleton<ITestD25, TestD25>(container);
            _registration.RegisterSingleton<ITestD26, TestD26>(container);
            _registration.RegisterSingleton<ITestD27, TestD27>(container);
            _registration.RegisterSingleton<ITestD28, TestD28>(container);
            _registration.RegisterSingleton<ITestD29, TestD29>(container);

            _registration.RegisterSingleton<ITestD30, TestD30>(container);
            _registration.RegisterSingleton<ITestD31, TestD31>(container);
            _registration.RegisterSingleton<ITestD32, TestD32>(container);
            _registration.RegisterSingleton<ITestD33, TestD33>(container);
            _registration.RegisterSingleton<ITestD34, TestD34>(container);
            _registration.RegisterSingleton<ITestD35, TestD35>(container);
            _registration.RegisterSingleton<ITestD36, TestD36>(container);
            _registration.RegisterSingleton<ITestD37, TestD37>(container);
            _registration.RegisterSingleton<ITestD38, TestD38>(container);
            _registration.RegisterSingleton<ITestD39, TestD39>(container);

            _registration.RegisterSingleton<ITestD40, TestD40>(container);
            _registration.RegisterSingleton<ITestD41, TestD41>(container);
            _registration.RegisterSingleton<ITestD42, TestD42>(container);
            _registration.RegisterSingleton<ITestD43, TestD43>(container);
            _registration.RegisterSingleton<ITestD44, TestD44>(container);
            _registration.RegisterSingleton<ITestD45, TestD45>(container);
            _registration.RegisterSingleton<ITestD46, TestD46>(container);
            _registration.RegisterSingleton<ITestD47, TestD47>(container);
            _registration.RegisterSingleton<ITestD48, TestD48>(container);
            _registration.RegisterSingleton<ITestD49, TestD49>(container);

            _registration.RegisterSingleton<ITestD, TestD>(container);
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestD>(container, testCasesNumber);
        }
    }
}