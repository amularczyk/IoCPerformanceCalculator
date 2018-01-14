using NiquIoC.Enums;
using NiquIoC.Interfaces;

namespace PerformanceCalculator.Containers.TestsNiquIoCFull
{
    public class NiquIoCFullResolving : Resolving
    {
        public override T Resolve<T>(object container)
        {
            var c = (IContainerResolve)container;

            return c.Resolve<T>(ResolveKind.FullEmitFunction);
        }
    }
}