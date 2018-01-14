using System.Collections.Generic;
using PerformanceCalculator.Common;
using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Interfaces
{
    public interface IPerformanceTestsRunner
    {
        List<List<TestResult>> RunTests(string containerName, int repetitionsNumber,
            IEnumerable<PerformanceTestCase> testCases);
    }
}