namespace PerformanceCalculator.Common
{
    public enum RegistrationKind
    {
        None = 0,
        Singleton = 1,
        Transient = 2,
        TransientSingleton = 3,
        PerThread = 4,
        FactoryMethod = 5
    }
}