using NiquIoC;
using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;

namespace PerformanceCalculator.Containers.TestsNiquIoCPartial
{
    public class NiquIoCPartialPerformanceTest : PerformanceTest
    {
        protected override IRegistration GetRegistration()
        {
            return new NiquIoCPartialRegistration();
        }

        protected override IResolving GetResolving()
        {
            return new NiquIoCPartialResolving();
        }

        protected override object GetContainer(RegistrationKind registrationKind)
        {
            return new Container();
        }
    }
}