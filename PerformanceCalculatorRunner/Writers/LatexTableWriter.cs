using System.Collections.Generic;
using System.Linq;
using System.Text;
using PerformanceCalculator.Common;
using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Writers
{
    public abstract class LatexTableWriter : FileWriter
    {
        protected LatexTableWriter(string resultFile) : base(resultFile, "txt")
        {
        }

        public override void Write(Dictionary<string, IEnumerable<FinalTestResult>> results,
            IEnumerable<PerformanceTestCase> testCases)
        {
            var textResults = new List<string>();

            var testCasesGroupByTestCase = testCases.GroupBy(t => t.TestCase);
            foreach (var testCaseGroupByTestCase in testCasesGroupByTestCase)
            {
                var testCasesGroupByRegistrationKind = testCaseGroupByTestCase.GroupBy(t => t.RegistrationKind);
                foreach (var testCaseGroupByRegistrationKind in testCasesGroupByRegistrationKind)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine($"{testCaseGroupByTestCase.Key} - {testCaseGroupByRegistrationKind.Key}");
                    AppendHeader(testCaseGroupByRegistrationKind, sb);
                    AppendResults(results, testCaseGroupByTestCase.Key, testCaseGroupByRegistrationKind.Key, sb);

                    textResults.Add(sb.ToString());
                }
            }

            WriteToFile(textResults);
        }

        private static void AppendHeader(IGrouping<RegistrationKind, PerformanceTestCase> testCases, StringBuilder sb)
        {
            sb.Append("Ilość");
            foreach (var testCase in testCases.OrderBy(r => r.TestsCount))
            {
                sb.Append($" & & {testCase.TestsCount} &");
            }
            sb.Append(" \\\\ \\hline");
            sb.AppendLine();

            sb.Append(string.Concat(Enumerable.Repeat(" & min & max & avg", testCases.Count())));
            sb.Append(" \\\\ \\hline");
            sb.AppendLine();
        }

        private void AppendResults(Dictionary<string, IEnumerable<FinalTestResult>> results, string testCaseName,
            RegistrationKind registrationKind, StringBuilder sb)
        {
            foreach (var result in results)
            {
                AppendResult(testCaseName, registrationKind, sb, result);
            }
        }

        private void AppendResult(string testCaseName, RegistrationKind registrationKind, StringBuilder sb,
            KeyValuePair<string, IEnumerable<FinalTestResult>> result)
        {
            var currentValues = GetCurrentValues(testCaseName, registrationKind, result);

            sb.Append(result.Key);
            foreach (var currentValue in currentValues.OrderBy(r => r.TestCasesCount))
            {
                sb.Append(GetValuesAsText(currentValue));
            }
            sb.Append(" \\\\ \\hline");
            sb.AppendLine();
        }

        private static IEnumerable<FinalTestResult> GetCurrentValues(string testCaseName,
            RegistrationKind registrationKind, KeyValuePair<string, IEnumerable<FinalTestResult>> result)
        {
            return result.Value.Where(r => r.TestCaseName == testCaseName &&
                                           r.RegistrationKind == registrationKind);
        }

        protected abstract string GetValuesAsText(FinalTestResult currentValue);
    }
}