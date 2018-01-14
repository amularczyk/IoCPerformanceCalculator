using PerformanceCalculator.Common;

namespace PerformanceCalculatorRunner.Models
{
    public class PerformanceTestCase
    {
        public RegistrationKind RegistrationKind { get; set; }

        public int TestsCount { get; set; }

        public string TestCase { get; set; }
    }
}