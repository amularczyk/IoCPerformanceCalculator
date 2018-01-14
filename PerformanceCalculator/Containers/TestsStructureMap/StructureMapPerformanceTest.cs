using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;
using StructureMap;

namespace PerformanceCalculator.Containers.TestsStructureMap
{
    public class StructureMapPerformanceTest : PerformanceTest
    {
        protected override IRegistration GetRegistration()
        {
            return new StructureMapRegistration();
        }

        protected override IResolving GetResolving()
        {
            return new StructureMapResolving();
        }

        protected override object GetContainer(RegistrationKind registrationKind)
        {
            return new Container();
        }

        protected override void RunDispose(object container)
        {
            ((Container)container).Dispose();
        }
    }
}