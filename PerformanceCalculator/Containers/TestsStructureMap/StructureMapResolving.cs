using StructureMap;

namespace PerformanceCalculator.Containers.TestsStructureMap
{
    public class StructureMapResolving : Resolving
    {
        public override T Resolve<T>(object container)
        {
            if (container is IContext)
            {
                var c = (IContext)container;

                return c.GetInstance<T>();
            }
            else
            {
                var c = (Container)container;

                return c.GetInstance<T>();
            }
        }
    }
}