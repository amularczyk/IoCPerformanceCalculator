using NiquIoC;
using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;

namespace PerformanceCalculator.Containers.TestsNiquIoCFull
{
    public class NiquIoCFullPerformanceTest : PerformanceTest
    {
        protected override IRegistration GetRegistration()
        {
            return new NiquIoCFullRegistration();
        }

        protected override IResolving GetResolving()
        {
            return new NiquIoCFullResolving();
        }

        protected override object GetContainer(RegistrationKind registrationKind)
        {
            return new Container();
        }
    }
}