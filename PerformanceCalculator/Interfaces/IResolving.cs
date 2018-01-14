namespace PerformanceCalculator.Interfaces
{
    public interface IResolving
    {
        T Resolve<T>(object container)
            where T : class;

        void Resolve<T>(object container, int testCasesNumber)
            where T : class;
    }
}