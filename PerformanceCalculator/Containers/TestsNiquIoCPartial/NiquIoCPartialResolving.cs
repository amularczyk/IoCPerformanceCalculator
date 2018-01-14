using NiquIoC.Enums;
using NiquIoC.Interfaces;

namespace PerformanceCalculator.Containers.TestsNiquIoCPartial
{
    public class NiquIoCPartialResolving : Resolving
    {
        public override T Resolve<T>(object container)
        {
            var c = (IContainerResolve)container;

            return c.Resolve<T>(ResolveKind.PartialEmitFunction);
        }
    }
}