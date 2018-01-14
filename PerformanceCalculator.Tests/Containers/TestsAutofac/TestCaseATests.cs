using System.Threading;
using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerformanceCalculator.Common;
using PerformanceCalculator.Containers.TestsAutofac;
using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCase.TestCaseA;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.Tests.Containers.TestsAutofac
{
    [TestClass]
    public class TestCaseATests
    {
        [TestMethod]
        public void RegisterSingleton_Success()
        {
            ITestCase testCase = new SingletonTestCaseA(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.Singleton);

            var obj1 = c.Resolve<ITestA>();
            var obj2 = c.Resolve<ITestA>();


            CheckHelper.Check(obj1, true, true);
            CheckHelper.Check(obj2, true, true);
            CheckHelper.Check(obj1, obj2, true, true);
        }

        [TestMethod]
        public void RegisterTransient_Success()
        {
            ITestCase testCase = new TransientTestCaseA(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.Transient);

            var obj1 = c.Resolve<ITestA>();
            var obj2 = c.Resolve<ITestA>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }

        [TestMethod]
        public void RegisterTransientSingleton_Success()
        {
            ITestCase testCase = new TransientSingletonTestCaseA(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.TransientSingleton);

            var obj1 = c.Resolve<ITestA>();
            var obj2 = c.Resolve<ITestA>();


            CheckHelper.Check(obj1, false, true);
            CheckHelper.Check(obj2, false, true);
            CheckHelper.Check(obj1, obj2, false, true);
        }

        [TestMethod]
        public void RegisterPerThread_SameThread_Success()
        {
            ITestCase testCase = new PerThreadTestCaseA(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.PerThread);
            ITestA obj1 = null;
            ITestA obj2 = null;


            var thread = new Thread(() =>
            {
                using (var threadLifetime = c.BeginLifetimeScope())
                {
                    obj1 = threadLifetime.Resolve<ITestA>();
                    obj2 = threadLifetime.Resolve<ITestA>();
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
            ITestCase testCase = new PerThreadTestCaseA(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.PerThread);
            ITestA obj1 = null;
            ITestA obj2 = null;


            var thread1 = new Thread(() =>
            {
                using (var threadLifetime = c.BeginLifetimeScope())
                {
                    obj1 = threadLifetime.Resolve<ITestA>();
                }
            });
            var thread2 = new Thread(() =>
            {
                using (var threadLifetime = c.BeginLifetimeScope())
                {
                    obj2 = threadLifetime.Resolve<ITestA>();
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
            ITestCase testCase = new FactoryMethodTestCaseA(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.FactoryMethod);

            var obj1 = c.Resolve<ITestA>();
            var obj2 = c.Resolve<ITestA>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }
    }
}