using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseC
{
    public class PerThreadTestCaseC : TestCase
    {
        public PerThreadTestCaseC(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            _registration.RegisterPerThread<ITestC00, TestC00>(container);
            _registration.RegisterPerThread<ITestC01, TestC01>(container);
            _registration.RegisterPerThread<ITestC02, TestC02>(container);
            _registration.RegisterPerThread<ITestC03, TestC03>(container);
            _registration.RegisterPerThread<ITestC04, TestC04>(container);

            _registration.RegisterPerThread<ITestC10, TestC10>(container);
            _registration.RegisterPerThread<ITestC11, TestC11>(container);
            _registration.RegisterPerThread<ITestC12, TestC12>(container);
            _registration.RegisterPerThread<ITestC13, TestC13>(container);
            _registration.RegisterPerThread<ITestC14, TestC14>(container);

            _registration.RegisterPerThread<ITestC20, TestC20>(container);
            _registration.RegisterPerThread<ITestC21, TestC21>(container);
            _registration.RegisterPerThread<ITestC22, TestC22>(container);
            _registration.RegisterPerThread<ITestC23, TestC23>(container);
            _registration.RegisterPerThread<ITestC24, TestC24>(container);

            _registration.RegisterPerThread<ITestC30, TestC30>(container);
            _registration.RegisterPerThread<ITestC31, TestC31>(container);
            _registration.RegisterPerThread<ITestC32, TestC32>(container);
            _registration.RegisterPerThread<ITestC33, TestC33>(container);
            _registration.RegisterPerThread<ITestC34, TestC34>(container);

            _registration.RegisterPerThread<ITestC40, TestC40>(container);
            _registration.RegisterPerThread<ITestC41, TestC41>(container);
            _registration.RegisterPerThread<ITestC42, TestC42>(container);
            _registration.RegisterPerThread<ITestC43, TestC43>(container);
            _registration.RegisterPerThread<ITestC44, TestC44>(container);

            _registration.RegisterPerThread<ITestC, TestC>(container);
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestC>(container, testCasesNumber);
        }
    }
}