using System;
using PerformanceCalculatorRunner.Helpers;
using PerformanceCalculatorRunner.Models;
using PerformanceCalculatorRunner.Writers;

namespace PerformanceCalculatorRunner
{
    public class Program
    {
        private static readonly string _processPath =
            @"..\..\..\PerformanceCalculator\bin\Release\PerformanceCalculator.exe";

        private static readonly string _resultFile = $"PerformanceCalculator_{DateTime.Now:yyyy_MM_dd_HH_mm}";

        private static void Main(string[] args)
        {
            var repetitionsNumber = 1;

            var argsCount = 1;
            if (args.Length == argsCount)
            {
                int.TryParse(args[0], out repetitionsNumber);
            }

            var testCases = PerformanceTestCasesCreaterHelper.CreatePerformanceTestCases();

            var performanceTestsRunner = new PerformanceTestsRunner(_processPath);
            var results =
                PerformanceTestCasesRunnerHelper.RunPerformanceTests(performanceTestsRunner, repetitionsNumber,
                    testCases);

            var writer = WriterFactory.GetTextFormatter(WriteKind.LatexTableResolve, _resultFile);
            writer.Write(results, testCases);
        }
    }
}