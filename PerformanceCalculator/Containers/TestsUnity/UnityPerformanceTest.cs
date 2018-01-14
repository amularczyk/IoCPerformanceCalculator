using Microsoft.Practices.Unity;
using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;

namespace PerformanceCalculator.Containers.TestsUnity
{
    public class UnityPerformanceTest : PerformanceTest
    {
        protected override IRegistration GetRegistration()
        {
            return new UnityRegistration();
        }

        protected override IResolving GetResolving()
        {
            return new UnityResolving();
        }

        protected override object GetContainer(RegistrationKind registrationKind)
        {
            return new UnityContainer();
        }

        protected override void RunDispose(object container)
        {
            ((UnityContainer)container).Dispose();
        }
    }
}