using System;
using System.Collections.Generic;
using PerformanceCalculator.Common;

namespace PerformanceCalculator
{
    public class PerformanceCalculatorArguments
    {
        public PerformanceCalculatorArguments(IReadOnlyList<string> args)
        {
            Name = args[0];
            RegistrationKind = RegistrationKind.None;
            Count = 1;
            TestCase = TestCaseName.A;

            for (var i = 1; i < args.Count; i += 2)
            {
                switch (args[i])
                {
                    case "-r":
                        RegistrationKind = (RegistrationKind)Convert.ToInt32(args[i + 1]);
                        break;

                    case "-t":
                        TestCase = args[i + 1];
                        break;

                    case "-c":
                        Count = Convert.ToInt32(args[i + 1]);
                        break;

                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public string Name { get; set; }

        public RegistrationKind RegistrationKind { get; set; }

        public string TestCase { get; set; }

        public int Count { get; set; }
    }
}