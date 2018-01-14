using Ninject;

namespace PerformanceCalculator.Containers.TestsNinject
{
    public class NinjectResolving : Resolving
    {
        public override T Resolve<T>(object container)
        {
            if (container is StandardKernel)
            {
                var c = (StandardKernel)container;

                return c.Get<T>();
            }
            else
            {
                var c = (Ninject.Activation.Context)container;

                return c.Kernel.Get<T>();
            }
        }
    }
}