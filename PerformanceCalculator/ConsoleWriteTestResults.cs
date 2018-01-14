using System;
using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;

namespace PerformanceCalculator
{
    public class ConsoleWriteTestResults : IWriteTestResults
    {
        public void Write(string containerName, TestResult testResult)
        {
            Console.Write(
                $"{containerName} -r {(int)testResult.RegistrationKind} -t {testResult.TestCaseName} -c {testResult.TestCasesCount} -reg {testResult.RegisterTime} -res {testResult.ResolveTime}");
        }
    }
}