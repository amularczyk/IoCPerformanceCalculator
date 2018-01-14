using System;
using PerformanceCalculatorRunner.Interfaces;
using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Writers
{
    public static class WriterFactory
    {
        public static IWriter GetTextFormatter(WriteKind writeKind, string resultFile)
        {
            switch (writeKind)
            {
                case WriteKind.HorizontalBoth:
                    return new RegisterAndResolveCsvHorizontalFileWriter(resultFile);

                case WriteKind.HorizontalRegister:
                    return new RegisterCsvHorizontalFileWriter(resultFile);

                case WriteKind.HorizontalResolve:
                    return new ResolveCsvHorizontalFileWriter(resultFile);

                case WriteKind.VerticalBoth:
                    return new RegisterAndResolveCsvVerticalFileWriter(resultFile);

                case WriteKind.VerticalRegister:
                    return new RegisterCsvVerticalFileWriter(resultFile);

                case WriteKind.VerticalResolve:
                    return new ResolveCsvVerticalFileWriter(resultFile);

                case WriteKind.LatexTableResolve:
                    return new ResolveLatexTableWriter(resultFile);

                case WriteKind.LatexTableRegister:
                    return new RegisterLatexTableWriter(resultFile);

                default:
                    throw new ArgumentOutOfRangeException(nameof(writeKind), writeKind, null);
            }
        }
    }
}