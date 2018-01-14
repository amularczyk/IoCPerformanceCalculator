using System;
using System.Collections.Generic;
using System.Linq;
using PerformanceCalculator.Common;
using PerformanceCalculatorRunner.Interfaces;
using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Helpers
{
    public static class PerformanceTestCasesRunnerHelper
    {
        public static Dictionary<string, IEnumerable<FinalTestResult>> RunPerformanceTests(
            IPerformanceTestsRunner performanceTestsRunner, int repetitionsNumber,
            IReadOnlyCollection<PerformanceTestCase> testCases)
        {
            var results = new Dictionary<string, IEnumerable<FinalTestResult>>();

            AddPerformanceTests(results, ContainerName.Autofac, performanceTestsRunner, repetitionsNumber, testCases);
            AddPerformanceTests(results, ContainerName.DryIoc, performanceTestsRunner, repetitionsNumber, testCases);
            AddPerformanceTests(results, ContainerName.Grace, performanceTestsRunner, repetitionsNumber, testCases);
            AddPerformanceTests(results, ContainerName.LightInject, performanceTestsRunner, repetitionsNumber,
                testCases);
            AddPerformanceTests(results, ContainerName.Ninject, performanceTestsRunner, repetitionsNumber, testCases);
            AddPerformanceTests(results, ContainerName.NiquIoCPartial, performanceTestsRunner, repetitionsNumber,
                testCases);
            AddPerformanceTests(results, ContainerName.NiquIoCFull, performanceTestsRunner, repetitionsNumber,
                testCases);
            AddPerformanceTests(results, ContainerName.SimpleInjector, performanceTestsRunner, repetitionsNumber,
                testCases);
            AddPerformanceTests(results, ContainerName.StructureMap, performanceTestsRunner, repetitionsNumber,
                testCases);
            AddPerformanceTests(results, ContainerName.Unity, performanceTestsRunner, repetitionsNumber, testCases);
            AddPerformanceTests(results, ContainerName.Windsor, performanceTestsRunner, repetitionsNumber, testCases);

            return results;
        }

        private static void AddPerformanceTests(IDictionary<string, IEnumerable<FinalTestResult>> dict,
            string containerName, IPerformanceTestsRunner performanceTestsRunner, int repetitionsNumber,
            IEnumerable<PerformanceTestCase> testCases)
        {
            dict.Add(containerName,
                RunPerformanceTests(containerName, performanceTestsRunner, repetitionsNumber, testCases));
        }

        private static IEnumerable<FinalTestResult> RunPerformanceTests(string containerName,
            IPerformanceTestsRunner performanceTestsRunner, int repetitionsNumber,
            IEnumerable<PerformanceTestCase> testCases)
        {
            Console.WriteLine($"{containerName} start");
            var result =
                ProcessTestResults(performanceTestsRunner.RunTests(containerName, repetitionsNumber, testCases));
            Console.WriteLine($"{containerName} end");

            return result;
        }

        private static IEnumerable<FinalTestResult> ProcessTestResults(IEnumerable<List<TestResult>> testResults)
        {
            var finalTestResults = new List<FinalTestResult>();

            foreach (var testResult in testResults)
            {
                finalTestResults.Add(new FinalTestResult
                {
                    RegistrationKind = testResult[0].RegistrationKind,
                    TestCaseName = testResult[0].TestCaseName,
                    TestCasesCount = testResult[0].TestCasesCount,
                    MinRegisterTime = testResult.Min(t => t.RegisterTime),
                    MinResolveTime = testResult.Min(t => t.ResolveTime),
                    MaxRegisterTime = testResult.Max(t => t.RegisterTime),
                    MaxResolveTime = testResult.Max(t => t.ResolveTime),
                    AvgRegisterTime = (long)Math.Round(testResult.Average(t => t.RegisterTime), 0),
                    AvgResolveTime = (long)Math.Round(testResult.Average(t => t.ResolveTime), 0)
                });
            }

            return finalTestResults;
        }
    }
}