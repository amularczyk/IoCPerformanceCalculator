using PerformanceCalculator.Common;
using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Writers
{
    public class ResolveCsvVerticalFileWriter : CsvVerticalFileWriter
    {
        public ResolveCsvVerticalFileWriter(string resultFile) : base(resultFile)
        {
        }

        protected override string GetTestCaseColumnNameText(string containerName)
        {
            return $"{containerName};{containerName};{containerName};";
        }

        protected override string GetRegistrationKindColumnNameText(RegistrationKind registrationKind)
        {
            return $"{registrationKind};{registrationKind};{registrationKind};";
        }

        protected override string GetTestsCountColumnNameText(int testsCount)
        {
            return $"{testsCount};{testsCount};{testsCount};";
        }

        protected override string GetResultKindColumnNameText()
        {
            return "Min;Max;Avg;";
        }

        protected override string GetResultText(FinalTestResult testResult)
        {
            return $"{testResult.MinResolveTime};{testResult.MaxResolveTime};{testResult.AvgResolveTime};";
        }
    }
}