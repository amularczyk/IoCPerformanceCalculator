using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Writers
{
    public class RegisterLatexTableWriter : LatexTableWriter
    {
        public RegisterLatexTableWriter(string resultFile) : base(resultFile)
        {
        }

        protected override string GetValuesAsText(FinalTestResult currentValue)
        {
            return
                $" & {currentValue.MinRegisterTime} & {currentValue.MaxRegisterTime} & {currentValue.AvgRegisterTime}";
        }
    }
}