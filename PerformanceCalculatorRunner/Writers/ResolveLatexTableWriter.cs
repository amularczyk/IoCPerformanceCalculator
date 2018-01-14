using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Writers
{
    public class ResolveLatexTableWriter : LatexTableWriter
    {
        public ResolveLatexTableWriter(string resultFile) : base(resultFile)
        {
        }

        protected override string GetValuesAsText(FinalTestResult currentValue)
        {
            return $" & {currentValue.MinResolveTime} & {currentValue.MaxResolveTime} & {currentValue.AvgResolveTime}";
        }
    }
}