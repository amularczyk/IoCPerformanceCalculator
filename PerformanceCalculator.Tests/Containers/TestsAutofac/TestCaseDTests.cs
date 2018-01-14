using System.Threading;
using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerformanceCalculator.Common;
using PerformanceCalculator.Containers.TestsAutofac;
using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCase.TestCaseD;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.Tests.Containers.TestsAutofac
{
    [TestClass]
    public class TestCaseDTests
    {
        [TestMethod]
        public void RegisterSingleton_Success()
        {
            ITestCase testCase = new SingletonTestCaseD(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.Singleton);

            var obj1 = c.Resolve<ITestD>();
            var obj2 = c.Resolve<ITestD>();


            CheckHelper.Check(obj1, true, true);
            CheckHelper.Check(obj2, true, true);
            CheckHelper.Check(obj1, obj2, true, true);
        }

        [TestMethod]
        public void RegisterTransient_Success()
        {
            ITestCase testCase = new TransientTestCaseD(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.Transient);

            var obj1 = c.Resolve<ITestD>();
            var obj2 = c.Resolve<ITestD>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }

        [TestMethod]
        public void RegisterTransientSingleton_Success()
        {
            ITestCase testCase = new TransientSingletonTestCaseD(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.TransientSingleton);

            var obj1 = c.Resolve<ITestD>();
            var obj2 = c.Resolve<ITestD>();


            CheckHelper.Check(obj1, false, true);
            CheckHelper.Check(obj2, false, true);
            CheckHelper.Check(obj1, obj2, false, true);
        }

        [TestMethod]
        public void RegisterPerThread_SameThread_Success()
        {
            ITestCase testCase = new PerThreadTestCaseD(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.PerThread);
            ITestD obj1 = null;
            ITestD obj2 = null;


            var thread = new Thread(() =>
            {
                using (var threadLifetime = c.BeginLifetimeScope())
                {
                    obj1 = threadLifetime.Resolve<ITestD>();
                    obj2 = threadLifetime.Resolve<ITestD>();
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
            ITestCase testCase = new PerThreadTestCaseD(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.PerThread);
            ITestD obj1 = null;
            ITestD obj2 = null;


            var thread1 = new Thread(() =>
            {
                using (var threadLifetime = c.BeginLifetimeScope())
                {
                    obj1 = threadLifetime.Resolve<ITestD>();
                }
            });
            var thread2 = new Thread(() =>
            {
                using (var threadLifetime = c.BeginLifetimeScope())
                {
                    obj2 = threadLifetime.Resolve<ITestD>();
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
            ITestCase testCase = new FactoryMethodTestCaseD(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.FactoryMethod);

            var obj1 = c.Resolve<ITestD>();
            var obj2 = c.Resolve<ITestD>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }
    }
}