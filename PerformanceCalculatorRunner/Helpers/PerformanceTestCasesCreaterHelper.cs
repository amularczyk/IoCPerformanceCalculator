using System.Collections.Generic;
using PerformanceCalculator.Common;
using PerformanceCalculatorRunner.Models;

namespace PerformanceCalculatorRunner.Helpers
{
    public static class PerformanceTestCasesCreaterHelper
    {
        private static readonly int _testsCount1 = 1;
        private static readonly int _testsCount10 = 10;
        private static readonly int _testsCount100 = 100;
        private static readonly int _testsCount1000 = 1000;

        public static List<PerformanceTestCase> CreatePerformanceTestCasesForRegister()
        {
            var testCases = new List<PerformanceTestCase>();

            CreatePerformanceTestCasesAForRegister(testCases);
            CreatePerformanceTestCasesBForRegister(testCases);
            CreatePerformanceTestCasesCForRegister(testCases);
            CreatePerformanceTestCasesDForRegister(testCases);

            return testCases;
        }

        #region CreatePerformanceTestCasesForRegister
        private static void CreatePerformanceTestCasesAForRegister(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.A
            });
        }

        private static void CreatePerformanceTestCasesBForRegister(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.B
            });
        }

        private static void CreatePerformanceTestCasesCForRegister(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.C
            });
        }

        private static void CreatePerformanceTestCasesDForRegister(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.D
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.D
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.D
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.D
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.D
            });
        }
        #endregion CreatePerformanceTestCasesForRegister

        public static List<PerformanceTestCase> CreatePerformanceTestCases()
        {
            var testCases = new List<PerformanceTestCase>();

            CreatePerformanceTestCasesA(testCases);
            CreatePerformanceTestCasesB(testCases);
            CreatePerformanceTestCasesC(testCases);
            CreatePerformanceTestCasesD(testCases);

            return testCases;
        }

        #region CreatePerformanceTestCasesA
        private static void CreatePerformanceTestCasesA(ICollection<PerformanceTestCase> testCases)
        {
            CreatePerformanceTestCasesASingleton(testCases);
            CreatePerformanceTestCasesATransient(testCases);
            CreatePerformanceTestCasesATransientSingleton(testCases);
            CreatePerformanceTestCasesAPerThread(testCases);
            CreatePerformanceTestCasesAFactoryMethod(testCases);
        }

        private static void CreatePerformanceTestCasesASingleton(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.A
            });
        }

        private static void CreatePerformanceTestCasesATransient(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.A
            });
        }

        private static void CreatePerformanceTestCasesATransientSingleton(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.A
            });
        }

        private static void CreatePerformanceTestCasesAPerThread(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.A
            });
        }

        private static void CreatePerformanceTestCasesAFactoryMethod(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.A
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.A
            });
        }
        #endregion CreatePerformanceTestCasesA

        #region CreatePerformanceTestCasesB
        private static void CreatePerformanceTestCasesB(ICollection<PerformanceTestCase> testCases)
        {
            CreatePerformanceTestCasesBSingleton(testCases);
            CreatePerformanceTestCasesBTransient(testCases);
            CreatePerformanceTestCasesBTransientSingleton(testCases);
            CreatePerformanceTestCasesBPerThread(testCases);
            CreatePerformanceTestCasesBFactoryMethod(testCases);
        }

        private static void CreatePerformanceTestCasesBSingleton(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.B
            });
        }

        private static void CreatePerformanceTestCasesBTransient(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.B
            });
        }

        private static void CreatePerformanceTestCasesBTransientSingleton(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.B
            });
        }

        private static void CreatePerformanceTestCasesBPerThread(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.B
            });
        }

        private static void CreatePerformanceTestCasesBFactoryMethod(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.B
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.B
            });
        }
        #endregion CreatePerformanceTestCasesB

        #region CreatePerformanceTestCasesC
        private static void CreatePerformanceTestCasesC(ICollection<PerformanceTestCase> testCases)
        {
            CreatePerformanceTestCasesCSingleton(testCases);
            CreatePerformanceTestCasesCTransient(testCases);
            CreatePerformanceTestCasesCTransientSingleton(testCases);
            CreatePerformanceTestCasesCPerThread(testCases);
            CreatePerformanceTestCasesCFactoryMethod(testCases);
        }

        private static void CreatePerformanceTestCasesCSingleton(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.C
            });
        }

        private static void CreatePerformanceTestCasesCTransient(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.C
            });
        }

        private static void CreatePerformanceTestCasesCTransientSingleton(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.C
            });
        }

        private static void CreatePerformanceTestCasesCPerThread(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.C
            });
        }

        private static void CreatePerformanceTestCasesCFactoryMethod(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount100,
                TestCase = TestCaseName.C
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount1000,
                TestCase = TestCaseName.C
            });
        }
        #endregion CreatePerformanceTestCasesC

        #region CreatePerformanceTestCasesD
        private static void CreatePerformanceTestCasesD(ICollection<PerformanceTestCase> testCases)
        {
            CreatePerformanceTestCasesDSingleton(testCases);
            CreatePerformanceTestCasesDTransient(testCases);
            CreatePerformanceTestCasesDTransientSingleton(testCases);
            CreatePerformanceTestCasesDPerThread(testCases);
            CreatePerformanceTestCasesDFactoryMethod(testCases);
        }

        private static void CreatePerformanceTestCasesDSingleton(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.D
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Singleton,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.D
            });
        }

        private static void CreatePerformanceTestCasesDTransient(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.D
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.Transient,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.D
            });
        }

        private static void CreatePerformanceTestCasesDTransientSingleton(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.D
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.TransientSingleton,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.D
            });
        }

        private static void CreatePerformanceTestCasesDPerThread(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.D
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.PerThread,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.D
            });
        }

        private static void CreatePerformanceTestCasesDFactoryMethod(ICollection<PerformanceTestCase> testCases)
        {
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount1,
                TestCase = TestCaseName.D
            });
            testCases.Add(new PerformanceTestCase
            {
                RegistrationKind = RegistrationKind.FactoryMethod,
                TestsCount = _testsCount10,
                TestCase = TestCaseName.D
            });
        }
        #endregion CreatePerformanceTestCasesD
    }
}