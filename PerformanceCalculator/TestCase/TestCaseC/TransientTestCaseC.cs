using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.TestCase.TestCaseC
{
    public class TransientTestCaseC : TestCase
    {
        public TransientTestCaseC(IRegistration registration, IResolving resolving)
            : base(registration, resolving)
        {
        }

        public override void RegisterClasses(object container)
        {
            _registration.RegisterTransient<ITestC00, TestC00>(container);
            _registration.RegisterTransient<ITestC01, TestC01>(container);
            _registration.RegisterTransient<ITestC02, TestC02>(container);
            _registration.RegisterTransient<ITestC03, TestC03>(container);
            _registration.RegisterTransient<ITestC04, TestC04>(container);

            _registration.RegisterTransient<ITestC10, TestC10>(container);
            _registration.RegisterTransient<ITestC11, TestC11>(container);
            _registration.RegisterTransient<ITestC12, TestC12>(container);
            _registration.RegisterTransient<ITestC13, TestC13>(container);
            _registration.RegisterTransient<ITestC14, TestC14>(container);

            _registration.RegisterTransient<ITestC20, TestC20>(container);
            _registration.RegisterTransient<ITestC21, TestC21>(container);
            _registration.RegisterTransient<ITestC22, TestC22>(container);
            _registration.RegisterTransient<ITestC23, TestC23>(container);
            _registration.RegisterTransient<ITestC24, TestC24>(container);

            _registration.RegisterTransient<ITestC30, TestC30>(container);
            _registration.RegisterTransient<ITestC31, TestC31>(container);
            _registration.RegisterTransient<ITestC32, TestC32>(container);
            _registration.RegisterTransient<ITestC33, TestC33>(container);
            _registration.RegisterTransient<ITestC34, TestC34>(container);

            _registration.RegisterTransient<ITestC40, TestC40>(container);
            _registration.RegisterTransient<ITestC41, TestC41>(container);
            _registration.RegisterTransient<ITestC42, TestC42>(container);
            _registration.RegisterTransient<ITestC43, TestC43>(container);
            _registration.RegisterTransient<ITestC44, TestC44>(container);

            _registration.RegisterTransient<ITestC, TestC>(container);
        }

        public override void Resolve(object container, int testCasesNumber)
        {
            _resolving.Resolve<ITestC>(container, testCasesNumber);
        }
    }
}