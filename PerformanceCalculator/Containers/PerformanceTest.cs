using System;
using System.Diagnostics;
using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCase.TestCaseA;
using PerformanceCalculator.TestCase.TestCaseB;
using PerformanceCalculator.TestCase.TestCaseC;
using PerformanceCalculator.TestCase.TestCaseD;

namespace PerformanceCalculator.Containers
{
    public abstract class PerformanceTest : IPerformanceTest
    {
        public TestResult RunTest(int count, string testCaseName, RegistrationKind registrationKind)
        {
            var testResult = new TestResult
            {
                TestCaseName = testCaseName,
                RegistrationKind = registrationKind,
                TestCasesCount = count
            };
            var sw = new Stopwatch();

            var testCase = GetTestCase(testCaseName, registrationKind);
            var container = RunRegister(sw, testCase, GetContainer(registrationKind), registrationKind);
            testResult.RegisterTime = sw.ElapsedMilliseconds;

            sw.Reset();
            testResult.ResolveTime = RunResolve(sw, testCase, container, count, registrationKind);

            RunDispose(container);

            return testResult;
        }

        protected ITestCase GetTestCase(string testCase, RegistrationKind registrationKind)
        {
            switch (testCase)
            {
                case TestCaseName.A:
                    switch (registrationKind)
                    {
                        case RegistrationKind.Singleton:
                            return new SingletonTestCaseA(GetRegistration(), GetResolving());

                        case RegistrationKind.Transient:
                            return new TransientTestCaseA(GetRegistration(), GetResolving());

                        case RegistrationKind.TransientSingleton:
                            return new TransientSingletonTestCaseA(GetRegistration(), GetResolving());

                        case RegistrationKind.PerThread:
                            return new PerThreadTestCaseA(GetRegistration(), GetResolving());

                        case RegistrationKind.FactoryMethod:
                            return new FactoryMethodTestCaseA(GetRegistration(), GetResolving());

                        default:
                            throw new ArgumentOutOfRangeException(nameof(registrationKind), registrationKind, null);
                    }

                case TestCaseName.B:
                    switch (registrationKind)
                    {
                        case RegistrationKind.Singleton:
                            return new SingletonTestCaseB(GetRegistration(), GetResolving());

                        case RegistrationKind.Transient:
                            return new TransientTestCaseB(GetRegistration(), GetResolving());

                        case RegistrationKind.TransientSingleton:
                            return new TransientSingletonTestCaseB(GetRegistration(), GetResolving());

                        case RegistrationKind.PerThread:
                            return new PerThreadTestCaseB(GetRegistration(), GetResolving());

                        case RegistrationKind.FactoryMethod:
                            return new FactoryMethodTestCaseB(GetRegistration(), GetResolving());

                        default:
                            throw new ArgumentOutOfRangeException(nameof(registrationKind), registrationKind, null);
                    }

                case TestCaseName.C:
                    switch (registrationKind)
                    {
                        case RegistrationKind.Singleton:
                            return new SingletonTestCaseC(GetRegistration(), GetResolving());

                        case RegistrationKind.Transient:
                            return new TransientTestCaseC(GetRegistration(), GetResolving());

                        case RegistrationKind.TransientSingleton:
                            return new TransientSingletonTestCaseC(GetRegistration(), GetResolving());

                        case RegistrationKind.PerThread:
                            return new PerThreadTestCaseC(GetRegistration(), GetResolving());

                        case RegistrationKind.FactoryMethod:
                            return new FactoryMethodTestCaseC(GetRegistration(), GetResolving());

                        default:
                            throw new ArgumentOutOfRangeException(nameof(registrationKind), registrationKind, null);
                    }

                case TestCaseName.D:
                    switch (registrationKind)
                    {
                        case RegistrationKind.Singleton:
                            return new SingletonTestCaseD(GetRegistration(), GetResolving());

                        case RegistrationKind.Transient:
                            return new TransientTestCaseD(GetRegistration(), GetResolving());

                        case RegistrationKind.TransientSingleton:
                            return new TransientSingletonTestCaseD(GetRegistration(), GetResolving());

                        case RegistrationKind.PerThread:
                            return new PerThreadTestCaseD(GetRegistration(), GetResolving());

                        case RegistrationKind.FactoryMethod:
                            return new FactoryMethodTestCaseD(GetRegistration(), GetResolving());

                        default:
                            throw new ArgumentOutOfRangeException(nameof(registrationKind), registrationKind, null);
                    }

                default:
                    throw new ArgumentOutOfRangeException(nameof(registrationKind), registrationKind, null);
            }
        }

        protected abstract IRegistration GetRegistration();

        protected abstract IResolving GetResolving();

        protected abstract object GetContainer(RegistrationKind registrationKind);

        protected virtual object RunRegister(Stopwatch sw, ITestCase testCase, object container,
            RegistrationKind registrationKind)
        {
            sw.Start();
            var newContainer = testCase.Register(container, registrationKind);
            sw.Stop();

            return newContainer;
        }

        protected virtual long RunResolve(Stopwatch sw, ITestCase testCase, object container, int testCasesCount,
            RegistrationKind registrationKind)
        {
            try
            {
                sw.Start();
                testCase.Resolve(container, testCasesCount);
                sw.Stop();
                return sw.ElapsedMilliseconds;
            }
            catch (OutOfMemoryException)
            {
                return -1;
            }
        }

        protected virtual void RunDispose(object container)
        {
        }
    }
}