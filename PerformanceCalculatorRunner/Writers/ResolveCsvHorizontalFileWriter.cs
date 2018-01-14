using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Writers
{
    public class ResolveCsvHorizontalFileWriter : CsvHorizontalFileWriter
    {
        public ResolveCsvHorizontalFileWriter(string resultFile) : base(resultFile)
        {
        }

        protected override string GetColumnNameText(string containerName)
        {
            return $"{containerName};";
        }

        protected override string GetMinResultText(FinalTestResult testResult)
        {
            return $"{testResult.MinResolveTime};";
        }

        protected override string GetMaxResultText(FinalTestResult testResult)
        {
            return $"{testResult.MaxResolveTime};";
        }

        protected override string GetAvgResultText(FinalTestResult testResult)
        {
            return $"{testResult.AvgResolveTime};";
        }
    }
}