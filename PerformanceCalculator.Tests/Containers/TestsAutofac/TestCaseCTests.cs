using System.Threading;
using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerformanceCalculator.Common;
using PerformanceCalculator.Containers.TestsAutofac;
using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCase.TestCaseC;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.Tests.Containers.TestsAutofac
{
    [TestClass]
    public class TestCaseCTests
    {
        [TestMethod]
        public void RegisterSingleton_Success()
        {
            ITestCase testCase = new SingletonTestCaseC(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.Singleton);

            var obj1 = c.Resolve<ITestC>();
            var obj2 = c.Resolve<ITestC>();


            CheckHelper.Check(obj1, true, true);
            CheckHelper.Check(obj2, true, true);
            CheckHelper.Check(obj1, obj2, true, true);
        }

        [TestMethod]
        public void RegisterTransient_Success()
        {
            ITestCase testCase = new TransientTestCaseC(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.Transient);

            var obj1 = c.Resolve<ITestC>();
            var obj2 = c.Resolve<ITestC>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }

        [TestMethod]
        public void RegisterTransientSingleton_Success()
        {
            ITestCase testCase = new TransientSingletonTestCaseC(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.TransientSingleton);

            var obj1 = c.Resolve<ITestC>();
            var obj2 = c.Resolve<ITestC>();


            CheckHelper.Check(obj1, false, true);
            CheckHelper.Check(obj2, false, true);
            CheckHelper.Check(obj1, obj2, false, true);
        }

        [TestMethod]
        public void RegisterPerThread_SameThread_Success()
        {
            ITestCase testCase = new PerThreadTestCaseC(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.PerThread);
            ITestC obj1 = null;
            ITestC obj2 = null;


            var thread = new Thread(() =>
            {
                using (var threadLifetime = c.BeginLifetimeScope())
                {
                    obj1 = threadLifetime.Resolve<ITestC>();
                    obj2 = threadLifetime.Resolve<ITestC>();
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
            ITestCase testCase = new PerThreadTestCaseC(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.PerThread);
            ITestC obj1 = null;
            ITestC obj2 = null;


            var thread1 = new Thread(() =>
            {
                using (var threadLifetime = c.BeginLifetimeScope())
                {
                    obj1 = threadLifetime.Resolve<ITestC>();
                }
            });
            var thread2 = new Thread(() =>
            {
                using (var threadLifetime = c.BeginLifetimeScope())
                {
                    obj2 = threadLifetime.Resolve<ITestC>();
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
            ITestCase testCase = new FactoryMethodTestCaseC(new AutofacRegistration(), new AutofacResolving());

            var cb = new ContainerBuilder();
            var c = (IContainer)testCase.Register(cb, RegistrationKind.FactoryMethod);

            var obj1 = c.Resolve<ITestC>();
            var obj2 = c.Resolve<ITestC>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }
    }
}