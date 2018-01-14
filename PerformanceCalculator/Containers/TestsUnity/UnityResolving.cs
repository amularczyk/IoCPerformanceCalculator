using Microsoft.Practices.Unity;

namespace PerformanceCalculator.Containers.TestsUnity
{
    public class UnityResolving : Resolving
    {
        public override T Resolve<T>(object container)
        {
            var c = (UnityContainer)container;

            return c.Resolve<T>();
        }
    }
}