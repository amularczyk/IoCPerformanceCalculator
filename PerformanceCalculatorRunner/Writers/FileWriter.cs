using System.Collections.Generic;
using System.IO;
using PerformanceCalculatorRunner.Interfaces;
using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Writers
{
    public abstract class FileWriter : IWriter
    {
        private readonly string _resultFile;

        protected FileWriter(string resultFile, string extension)
        {
            _resultFile = $"{resultFile}.{extension}";
        }

        public abstract void Write(Dictionary<string, IEnumerable<FinalTestResult>> results,
            IEnumerable<PerformanceTestCase> testCases);

        protected void WriteToFile(IEnumerable<string> results)
        {
            using (var file = new StreamWriter(_resultFile))
            {
                foreach (var result in results)
                {
                    file.WriteLine(result);
                }
            }
        }
    }
}