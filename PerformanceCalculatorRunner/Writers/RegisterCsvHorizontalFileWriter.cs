using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Writers
{
    public class RegisterCsvHorizontalFileWriter : CsvHorizontalFileWriter
    {
        public RegisterCsvHorizontalFileWriter(string resultFile) : base(resultFile)
        {
        }

        protected override string GetColumnNameText(string containerName)
        {
            return $"{containerName};";
        }

        protected override string GetMinResultText(FinalTestResult testResult)
        {
            return $"{testResult.MinRegisterTime};";
        }

        protected override string GetMaxResultText(FinalTestResult testResult)
        {
            return $"{testResult.MaxRegisterTime};";
        }

        protected override string GetAvgResultText(FinalTestResult testResult)
        {
            return $"{testResult.AvgRegisterTime};";
        }
    }
}