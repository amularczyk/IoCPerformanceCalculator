using SimpleInjector;

namespace PerformanceCalculator.Containers.TestsSimpleInjector
{
    public class SimpleInjectorResolving : Resolving
    {
        public override T Resolve<T>(object container)
        {
            var c = (Container)container;

            return c.GetInstance<T>();
        }
    }
}