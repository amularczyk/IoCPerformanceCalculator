using PerformanceCalculator.Common;

namespace PerformanceCalculator.Interfaces
{
    public interface IWriteTestResults
    {
        void Write(string containerName, TestResult testResult);
    }
}