using System.Collections.Generic;
using System.Linq;
using System.Text;
using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Writers
{
    public abstract class CsvHorizontalFileWriter : FileWriter
    {
        protected CsvHorizontalFileWriter(string resultFile) : base(resultFile, "csv")
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
            var dict = new Dictionary<string, StringBuilder>();

            var columnsNames = "cn";
            var columnsNamesSb = new StringBuilder();
            columnsNamesSb.Append("Test Case;Registration Kind;Resolve Count;Result Kind;");
            dict.Add(columnsNames, columnsNamesSb);

            foreach (var testCase in testCases)
            {
                var name = $"{testCase.TestCase};{testCase.RegistrationKind};{testCase.TestsCount}";

                var rowHeaderMin = new StringBuilder();
                var nameMin = $"{name};min";
                rowHeaderMin.Append($"Test {nameMin};");
                var rowHeaderMax = new StringBuilder();
                var nameMax = $"{name};max";
                rowHeaderMax.Append($"Test {nameMax};");
                var rowHeaderAvg = new StringBuilder();
                var nameMvg = $"{name};avg";
                rowHeaderAvg.Append($"Test {nameMvg};");

                dict.Add(nameMin, rowHeaderMin);
                dict.Add(nameMax, rowHeaderMax);
                dict.Add(nameMvg, rowHeaderAvg);
            }

            foreach (var result in results)
            {
                dict[columnsNames].Append(GetColumnNameText(result.Key));

                foreach (var testResult in result.Value)
                {
                    var name = $"{testResult.TestCaseName};{testResult.RegistrationKind};{testResult.TestCasesCount}";

                    var nameMin = $"{name};min";
                    dict[nameMin].Append(GetMinResultText(testResult));

                    var nameMax = $"{name};max";
                    dict[nameMax].Append(GetMaxResultText(testResult));

                    var nameMvg = $"{name};avg";
                    dict[nameMvg].Append(GetAvgResultText(testResult));
                }
            }


            return dict.Select(d => d.Value.ToString()).ToList();
        }

        protected abstract string GetColumnNameText(string containerName);

        protected abstract string GetMinResultText(FinalTestResult testResult);

        protected abstract string GetMaxResultText(FinalTestResult testResult);

        protected abstract string GetAvgResultText(FinalTestResult testResult);
    }
}