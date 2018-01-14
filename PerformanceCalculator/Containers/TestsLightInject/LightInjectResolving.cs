using LightInject;

namespace PerformanceCalculator.Containers.TestsLightInject
{
    public class LightInjectResolving : Resolving
    {
        public override T Resolve<T>(object container)
        {
            var c = (ServiceContainer)container;

            return c.GetInstance<T>();
        }
    }
}