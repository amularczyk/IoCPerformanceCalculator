using System.Collections.Generic;
using System.Linq;
using System.Text;
using PerformanceCalculator.Common;
using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Writers
{
    public abstract class CsvVerticalFileWriter : FileWriter
    {
        protected CsvVerticalFileWriter(string resultFile) : base(resultFile, "csv")
        {
        }

        public override void Write(Dictionary<string, IEnumerable<FinalTestResult>> results,
            IEnumerable<PerformanceTestCase> testCases)
        {
            WriteToFile(ProcessResultsDataToCsvFormat(results, testCases));
        }

        private IEnumerable<string> ProcessResultsDataToCsvFormat(
            Dictionary<string, IEnumerable<FinalTestResult>> results, IEnumerable<PerformanceTestCase> testCases)
        {
            var list = new List<StringBuilder>();

            var hTestCase = new StringBuilder();
            var hRegistrationKind = new StringBuilder();
            var hTestsCount = new StringBuilder();
            var hResultKind = new StringBuilder();

            hTestCase.Append(";");
            hRegistrationKind.Append(";");
            hTestsCount.Append(";");
            hResultKind.Append(";");

            foreach (var testCase in testCases)
            {
                hTestCase.Append(GetTestCaseColumnNameText(testCase.TestCase));
                hRegistrationKind.Append(GetRegistrationKindColumnNameText(testCase.RegistrationKind));
                hTestsCount.Append(GetTestsCountColumnNameText(testCase.TestsCount));
                hResultKind.Append(GetResultKindColumnNameText());
            }

            list.Add(hTestCase);
            list.Add(hRegistrationKind);
            list.Add(hTestsCount);
            list.Add(hResultKind);

            foreach (var result in results)
            {
                var sbResult = new StringBuilder();

                sbResult.Append($"{result.Key};");

                foreach (var testResult in result.Value)
                {
                    sbResult.Append(GetResultText(testResult));
                }

                list.Add(sbResult);
            }

            return list.Select(l => l.ToString());
        }

        protected abstract string GetTestCaseColumnNameText(string containerName);

        protected abstract string GetRegistrationKindColumnNameText(RegistrationKind registrationKind);

        protected abstract string GetTestsCountColumnNameText(int testsCount);

        protected abstract string GetResultKindColumnNameText();

        protected abstract string GetResultText(FinalTestResult testResult);
    }
}