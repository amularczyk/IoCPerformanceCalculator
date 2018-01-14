using Grace.DependencyInjection;

namespace PerformanceCalculator.Containers.TestsGrace
{
    public class GraceResolving : Resolving
    {
        public override T Resolve<T>(object container)
        {
            if (container is IExportLocatorScope)
            {
                var c = (IExportLocatorScope)container;

                return c.Locate<T>();
            }
            else
            {
                // ReSharper disable once PossibleInvalidCastException
                var c = (DependencyInjectionContainer)container;

                return c.Locate<T>();
            }
        }
    }
}