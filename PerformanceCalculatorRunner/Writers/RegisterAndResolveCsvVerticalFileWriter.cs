using PerformanceCalculator.Common;
using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Writers
{
    public class RegisterAndResolveCsvVerticalFileWriter : CsvVerticalFileWriter
    {
        public RegisterAndResolveCsvVerticalFileWriter(string resultFile) : base(resultFile)
        {
        }

        protected override string GetTestCaseColumnNameText(string containerName)
        {
            return
                $"{containerName} Register;{containerName} Register;{containerName} Register;{containerName} Resolve;{containerName} Resolve;{containerName} Resolve;";
        }

        protected override string GetRegistrationKindColumnNameText(RegistrationKind registrationKind)
        {
            return
                $"{registrationKind};{registrationKind};{registrationKind};{registrationKind};{registrationKind};{registrationKind};";
        }

        protected override string GetTestsCountColumnNameText(int testsCount)
        {
            return $"{testsCount};{testsCount};{testsCount};{testsCount};{testsCount};{testsCount};";
        }

        protected override string GetResultKindColumnNameText()
        {
            return "Min;Max;Avg;Min;Max;Avg;";
        }

        protected override string GetResultText(FinalTestResult testResult)
        {
            return
                $"{testResult.MinRegisterTime};{testResult.MaxRegisterTime};{testResult.AvgRegisterTime};{testResult.MinResolveTime};{testResult.MaxResolveTime};{testResult.AvgResolveTime};";
        }
    }
}