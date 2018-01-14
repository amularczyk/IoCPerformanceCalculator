using Castle.MicroKernel;
using Castle.Windsor;

namespace PerformanceCalculator.Containers.TestsWindsor
{
    public class WindsorResolving : Resolving
    {
        public override T Resolve<T>(object container)
        {
            if (container is DefaultKernel)
            {
                var c = (DefaultKernel)container;

                return c.Resolve<T>();
            }
            else
            {
                var c = (WindsorContainer)container;

                return c.Resolve<T>();
            }
        }
    }
}