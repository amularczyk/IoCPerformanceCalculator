using System.Threading;
using Grace.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerformanceCalculator.Common;
using PerformanceCalculator.Containers.TestsGrace;
using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCase.TestCaseA;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.Tests.Containers.TestsGrace
{
    [TestClass]
    public class TestCaseATests
    {
        [TestMethod]
        public void RegisterSingleton_Success()
        {
            ITestCase testCase = new SingletonTestCaseA(new GraceRegistration(), new GraceResolving());

            var c = new DependencyInjectionContainer();
            c = (DependencyInjectionContainer)testCase.Register(c, RegistrationKind.Singleton);


            var obj1 = c.Locate<ITestA>();
            var obj2 = c.Locate<ITestA>();


            CheckHelper.Check(obj1, true, true);
            CheckHelper.Check(obj2, true, true);
            CheckHelper.Check(obj1, obj2, true, true);
        }

        [TestMethod]
        public void RegisterTransient_Success()
        {
            ITestCase testCase = new TransientTestCaseA(new GraceRegistration(), new GraceResolving());

            var c = new DependencyInjectionContainer();
            c = (DependencyInjectionContainer)testCase.Register(c, RegistrationKind.Transient);


            var obj1 = c.Locate<ITestA>();
            var obj2 = c.Locate<ITestA>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }

        [TestMethod]
        public void RegisterTransientSingleton_Success()
        {
            ITestCase testCase = new TransientSingletonTestCaseA(new GraceRegistration(), new GraceResolving());

            var c = new DependencyInjectionContainer();
            c = (DependencyInjectionContainer)testCase.Register(c, RegistrationKind.TransientSingleton);

            var obj1 = c.Locate<ITestA>();
            var obj2 = c.Locate<ITestA>();


            CheckHelper.Check(obj1, false, true);
            CheckHelper.Check(obj2, false, true);
            CheckHelper.Check(obj1, obj2, false, true);
        }

        [TestMethod]
        public void RegisterPerThread_SameThread_Success()
        {
            ITestCase testCase = new PerThreadTestCaseA(new GraceRegistration(), new GraceResolving());

            var c = new DependencyInjectionContainer();
            c = (DependencyInjectionContainer)testCase.Register(c, RegistrationKind.PerThread);
            ITestA obj1 = null;
            ITestA obj2 = null;


            var thread = new Thread(() =>
            {
                using (var scope = c.BeginLifetimeScope())
                {
                    obj1 = scope.Locate<ITestA>();
                    obj2 = scope.Locate<ITestA>();
                }
            });
            thread.Start();
            thread.Join();


            CheckHelper.Check(obj1, true, true);
            CheckHelper.Check(obj2, true, true);
            CheckHelper.Check(obj1, obj2, true, true);
        }

        [TestMethod]
        public void RegisterPerThread_DifferentThreads_Success()
        {
            ITestCase testCase = new PerThreadTestCaseA(new GraceRegistration(), new GraceResolving());

            var c = new DependencyInjectionContainer();
            c = (DependencyInjectionContainer)testCase.Register(c, RegistrationKind.PerThread);
            ITestA obj1 = null;
            ITestA obj2 = null;


            var thread1 = new Thread(() =>
            {
                using (var scope = c.BeginLifetimeScope())
                {
                    obj1 = scope.Locate<ITestA>();
                }
            });
            var thread2 = new Thread(() =>
            {
                using (var scope = c.BeginLifetimeScope())
                {
                    obj2 = scope.Locate<ITestA>();
                }
            });
            thread1.Start();
            thread1.Join();
            thread2.Start();
            thread2.Join();


            CheckHelper.Check(obj1, true, true);
            CheckHelper.Check(obj2, true, true);
            CheckHelper.Check(obj1, obj2, false, false);
        }

        [TestMethod]
        public void RegisterFactoryMethod_Success()
        {
            ITestCase testCase = new FactoryMethodTestCaseA(new GraceRegistration(), new GraceResolving());

            var c = new DependencyInjectionContainer();
            c = (DependencyInjectionContainer)testCase.Register(c, RegistrationKind.FactoryMethod);

            var obj1 = c.Locate<ITestA>();
            var obj2 = c.Locate<ITestA>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }
    }
}