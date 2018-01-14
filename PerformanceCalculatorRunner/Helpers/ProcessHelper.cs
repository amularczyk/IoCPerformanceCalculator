using System;
using System.Diagnostics;

namespace PerformanceCalculatorRunner.Helpers
{
    public static class ProcessHelper
    {
        public static string StartProcess(string fileName, string arguments)
        {
            var process = new Process
            {
                StartInfo =
                {
                    FileName = fileName,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false
                }
            };

            process.Start();
            var standardOutput = process.StandardOutput.ReadToEnd();
            var standardError = process.StandardError.ReadToEnd();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                throw new InvalidOperationException(
                    $"Process ended with Exit Code {process.ExitCode}. StandardError = {standardError}");
            }

            return standardOutput;
        }
    }
}