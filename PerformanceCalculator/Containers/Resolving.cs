using PerformanceCalculator.Interfaces;

namespace PerformanceCalculator.Containers
{
    public abstract class Resolving : IResolving
    {
        public abstract T Resolve<T>(object container)
            where T : class;

        public void Resolve<T>(object container, int testCasesNumber)
            where T : class
        {
            for (var i = 0; i < testCasesNumber; i++)
            {
                Resolve<T>(container);
            }
        }
    }
}