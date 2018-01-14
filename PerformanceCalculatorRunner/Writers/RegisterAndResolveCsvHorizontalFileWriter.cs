using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Writers
{
    public class RegisterAndResolveCsvHorizontalFileWriter : CsvHorizontalFileWriter
    {
        public RegisterAndResolveCsvHorizontalFileWriter(string resultFile) : base(resultFile)
        {
        }

        protected override string GetColumnNameText(string containerName)
        {
            return $"{containerName} Register;{containerName} Resolve;";
        }

        protected override string GetMinResultText(FinalTestResult testResult)
        {
            return $"{testResult.MinRegisterTime};{testResult.MinResolveTime};";
        }

        protected override string GetMaxResultText(FinalTestResult testResult)
        {
            return $"{testResult.MaxRegisterTime};{testResult.MaxResolveTime};";
        }

        protected override string GetAvgResultText(FinalTestResult testResult)
        {
            return $"{testResult.AvgRegisterTime};{testResult.AvgResolveTime};";
        }
    }
}