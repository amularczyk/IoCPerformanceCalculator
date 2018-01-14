using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseC
{
    public class SingletonTestCaseC : TestCase
    {
        public SingletonTestCaseC(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            _registration.RegisterSingleton<ITestC00, TestC00>(container);
            _registration.RegisterSingleton<ITestC01, TestC01>(container);
            _registration.RegisterSingleton<ITestC02, TestC02>(container);
            _registration.RegisterSingleton<ITestC03, TestC03>(container);
            _registration.RegisterSingleton<ITestC04, TestC04>(container);

            _registration.RegisterSingleton<ITestC10, TestC10>(container);
            _registration.RegisterSingleton<ITestC11, TestC11>(container);
            _registration.RegisterSingleton<ITestC12, TestC12>(container);
            _registration.RegisterSingleton<ITestC13, TestC13>(container);
            _registration.RegisterSingleton<ITestC14, TestC14>(container);

            _registration.RegisterSingleton<ITestC20, TestC20>(container);
            _registration.RegisterSingleton<ITestC21, TestC21>(container);
            _registration.RegisterSingleton<ITestC22, TestC22>(container);
            _registration.RegisterSingleton<ITestC23, TestC23>(container);
            _registration.RegisterSingleton<ITestC24, TestC24>(container);

            _registration.RegisterSingleton<ITestC30, TestC30>(container);
            _registration.RegisterSingleton<ITestC31, TestC31>(container);
            _registration.RegisterSingleton<ITestC32, TestC32>(container);
            _registration.RegisterSingleton<ITestC33, TestC33>(container);
            _registration.RegisterSingleton<ITestC34, TestC34>(container);

            _registration.RegisterSingleton<ITestC40, TestC40>(container);
            _registration.RegisterSingleton<ITestC41, TestC41>(container);
            _registration.RegisterSingleton<ITestC42, TestC42>(container);
            _registration.RegisterSingleton<ITestC43, TestC43>(container);
            _registration.RegisterSingleton<ITestC44, TestC44>(container);

            _registration.RegisterSingleton<ITestC, TestC>(container);
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestC>(container, testCasesNumber);
        }
    }
}