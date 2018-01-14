using System.Collections.Generic;
using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Interfaces
{
    public interface IWriter
    {
        void Write(Dictionary<string, IEnumerable<FinalTestResult>> results,
            IEnumerable<PerformanceTestCase> testCases);
    }
}