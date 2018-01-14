namespace PerformanceCalculator.Common
{
    public class TestResult
    {
        public RegistrationKind RegistrationKind { get; set; }

        public string TestCaseName { get; set; }

        public int TestCasesCount { get; set; }

        public long RegisterTime { get; set; }

        public long ResolveTime { get; set; }
    }
}