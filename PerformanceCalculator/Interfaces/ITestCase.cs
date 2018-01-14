using PerformanceCalculator.Common;

namespace PerformanceCalculator.Interfaces
{
    public interface ITestCase
    {
        object Register(object container, RegistrationKind registrationKind);

        void Resolve(object container, int testCasesNumber);
    }
}