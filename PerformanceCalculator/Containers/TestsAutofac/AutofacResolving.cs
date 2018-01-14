using Autofac;
using Autofac.Core.Resolving;

namespace PerformanceCalculator.Containers.TestsAutofac
{
    public class AutofacResolving : Resolving
    {
        public override T Resolve<T>(object container)
        {
            if (container is ILifetimeScope)
            {
                var c = (ILifetimeScope)container;

                return c.Resolve<T>();
            }
            else if (container is IInstanceLookup)
            {
                var c = (IInstanceLookup)container;

                return c.ActivationScope.Resolve<T>();
            }
            else
            {
                // ReSharper disable once PossibleInvalidCastException
                var c = (IContainer)container;

                return c.Resolve<T>();
            }
        }
    }
}