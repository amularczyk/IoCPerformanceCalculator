using System;

namespace PerformanceCalculator.Exceptions
{
    public class PerformanceTestNotFoundException : Exception
    {
        private readonly string _name;

        public PerformanceTestNotFoundException(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return $"PerformanceTestFactory didn't find match for {_name}.";
        }
    }
}