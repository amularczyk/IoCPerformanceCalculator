using DryIoc;

namespace PerformanceCalculator.Containers.TestsDryIoc
{
    public class DryIocResolving : Resolving
    {
        public override T Resolve<T>(object container)
        {
            var c = (Container)container;

            return c.Resolve<T>();
        }
    }
}