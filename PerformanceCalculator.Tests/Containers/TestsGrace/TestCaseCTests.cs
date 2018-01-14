using System.Threading;
using Grace.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerformanceCalculator.Common;
using PerformanceCalculator.Containers.TestsGrace;
using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCase.TestCaseC;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.Tests.Containers.TestsGrace
{
    [TestClass]
    public class TestCaseCTests
    {
        [TestMethod]
        public void RegisterSingleton_Success()
        {
            ITestCase testCase = new SingletonTestCaseC(new GraceRegistration(), new GraceResolving());

            var c = new DependencyInjectionContainer();
            c = (DependencyInjectionContainer)testCase.Register(c, RegistrationKind.Singleton);


            var obj1 = c.Locate<ITestC>();
            var obj2 = c.Locate<ITestC>();


            CheckHelper.Check(obj1, true, true);
            CheckHelper.Check(obj2, true, true);
            CheckHelper.Check(obj1, obj2, true, true);
        }

        [TestMethod]
        public void RegisterTransient_Success()
        {
            ITestCase testCase = new TransientTestCaseC(new GraceRegistration(), new GraceResolving());

            var c = new DependencyInjectionContainer();
            c = (DependencyInjectionContainer)testCase.Register(c, RegistrationKind.Transient);


            var obj1 = c.Locate<ITestC>();
            var obj2 = c.Locate<ITestC>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }

        [TestMethod]
        public void RegisterTransientSingleton_Success()
        {
            ITestCase testCase = new TransientSingletonTestCaseC(new GraceRegistration(), new GraceResolving());

            var c = new DependencyInjectionContainer();
            c = (DependencyInjectionContainer)testCase.Register(c, RegistrationKind.TransientSingleton);

            var obj1 = c.Locate<ITestC>();
            var obj2 = c.Locate<ITestC>();


            CheckHelper.Check(obj1, false, true);
            CheckHelper.Check(obj2, false, true);
            CheckHelper.Check(obj1, obj2, false, true);
        }

        [TestMethod]
        public void RegisterPerThread_SameThread_Success()
        {
            ITestCase testCase = new PerThreadTestCaseC(new GraceRegistration(), new GraceResolving());

            var c = new DependencyInjectionContainer();
            c = (DependencyInjectionContainer)testCase.Register(c, RegistrationKind.PerThread);
            ITestC obj1 = null;
            ITestC obj2 = null;


            var thread = new Thread(() =>
            {
                using (var scope = c.BeginLifetimeScope())
                {
                    obj1 = scope.Locate<ITestC>();
                    obj2 = scope.Locate<ITestC>();
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
            ITestCase testCase = new PerThreadTestCaseC(new GraceRegistration(), new GraceResolving());

            var c = new DependencyInjectionContainer();
            c = (DependencyInjectionContainer)testCase.Register(c, RegistrationKind.PerThread);
            ITestC obj1 = null;
            ITestC obj2 = null;


            var thread1 = new Thread(() =>
            {
                using (var scope = c.BeginLifetimeScope())
                {
                    obj1 = scope.Locate<ITestC>();
                }
            });
            var thread2 = new Thread(() =>
            {
                using (var scope = c.BeginLifetimeScope())
                {
                    obj2 = scope.Locate<ITestC>();
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
            ITestCase testCase = new FactoryMethodTestCaseC(new GraceRegistration(), new GraceResolving());

            var c = new DependencyInjectionContainer();
            c = (DependencyInjectionContainer)testCase.Register(c, RegistrationKind.FactoryMethod);

            var obj1 = c.Locate<ITestC>();
            var obj2 = c.Locate<ITestC>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }
    }
}