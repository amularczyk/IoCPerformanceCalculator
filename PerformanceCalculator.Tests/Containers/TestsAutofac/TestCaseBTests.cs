using System.Threading;
using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerformanceCalculator.Common;
using PerformanceCalculator.Containers.TestsAutofac;
using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCase.TestCaseB;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.Tests.Containers.TestsAutofac
{
    [TestClass]
    public class TestCaseBTests
    {
        [TestMethod]
        public void RegisterSingleton_Success()
        {
            ITestCase testCase = new SingletonTestCaseB(new AutofacRegistration(), new AutofacResolving());


            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.Singleton);

            var obj1 = c.Resolve<ITestB>();
            var obj2 = c.Resolve<ITestB>();


            CheckHelper.Check(obj1, true, true);
            CheckHelper.Check(obj2, true, true);
            CheckHelper.Check(obj1, obj2, true, true);
        }

        [TestMethod]
        public void RegisterTransient_Success()
        {
            ITestCase testCase = new TransientTestCaseB(new AutofacRegistration(), new AutofacResolving());


            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.Transient);

            var obj1 = c.Resolve<ITestB>();
            var obj2 = c.Resolve<ITestB>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }

        [TestMethod]
        public void RegisterTransientSingleton_Success()
        {
            ITestCase testCase = new TransientSingletonTestCaseB(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.TransientSingleton);

            var obj1 = c.Resolve<ITestB>();
            var obj2 = c.Resolve<ITestB>();


            CheckHelper.Check(obj1, false, true);
            CheckHelper.Check(obj2, false, true);
            CheckHelper.Check(obj1, obj2, false, true);
        }

        [TestMethod]
        public void RegisterPerThread_SameThread_Success()
        {
            ITestCase testCase = new PerThreadTestCaseB(new AutofacRegistration(), new AutofacResolving());


            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.PerThread);
            ITestB obj1 = null;
            ITestB obj2 = null;


            var thread = new Thread(() =>
            {
                using (var threadLifetime = c.BeginLifetimeScope())
                {
                    obj1 = threadLifetime.Resolve<ITestB>();
                    obj2 = threadLifetime.Resolve<ITestB>();
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
            ITestCase testCase = new PerThreadTestCaseB(new AutofacRegistration(), new AutofacResolving());


            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.PerThread);
            ITestB obj1 = null;
            ITestB obj2 = null;


            var thread1 = new Thread(() =>
            {
                using (var threadLifetime = c.BeginLifetimeScope())
                {
                    obj1 = threadLifetime.Resolve<ITestB>();
                }
            });
            var thread2 = new Thread(() =>
            {
                using (var threadLifetime = c.BeginLifetimeScope())
                {
                    obj2 = threadLifetime.Resolve<ITestB>();
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
            ITestCase testCase = new FactoryMethodTestCaseB(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.FactoryMethod);

            var obj1 = c.Resolve<ITestB>();
            var obj2 = c.Resolve<ITestB>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }
    }
}