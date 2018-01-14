using System.Threading;
using LightInject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerformanceCalculator.Common;
using PerformanceCalculator.Containers.TestsLightInject;
using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCase.TestCaseA;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.Tests.Containers.TestsLightInject
{
    [TestClass]
    public class TestCaseATests
    {
        [TestMethod]
        public void RegisterSingleton_Success()
        {
            ITestCase testCase = new SingletonTestCaseA(new LightInjectRegistration(), new LightInjectResolving());


            var c = new ServiceContainer();
            c = (ServiceContainer)testCase.Register(c, RegistrationKind.Singleton);

            var obj1 = c.GetInstance<ITestA>();
            var obj2 = c.GetInstance<ITestA>();


            CheckHelper.Check(obj1, true, true);
            CheckHelper.Check(obj2, true, true);
            CheckHelper.Check(obj1, obj2, true, true);
        }

        [TestMethod]
        public void RegisterTransient_Success()
        {
            ITestCase testCase = new TransientTestCaseA(new LightInjectRegistration(), new LightInjectResolving());


            var c = new ServiceContainer();
            c = (ServiceContainer)testCase.Register(c, RegistrationKind.Transient);

            var obj1 = c.GetInstance<ITestA>();
            var obj2 = c.GetInstance<ITestA>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }

        [TestMethod]
        public void RegisterTransientSingleton_Success()
        {
            ITestCase testCase =
                new TransientSingletonTestCaseA(new LightInjectRegistration(), new LightInjectResolving());

            var c = new ServiceContainer();
            c = (ServiceContainer)testCase.Register(c, RegistrationKind.TransientSingleton);

            var obj1 = c.GetInstance<ITestA>();
            var obj2 = c.GetInstance<ITestA>();


            CheckHelper.Check(obj1, false, true);
            CheckHelper.Check(obj2, false, true);
            CheckHelper.Check(obj1, obj2, false, true);
        }

        [TestMethod]
        public void RegisterPerThread_SameThread_Success()
        {
            ITestCase testCase = new PerThreadTestCaseA(new LightInjectRegistration(), new LightInjectResolving());

            var c = new ServiceContainer();
            c = (ServiceContainer)testCase.Register(c, RegistrationKind.PerThread);
            ITestA obj1 = null;
            ITestA obj2 = null;


            var thread = new Thread(() =>
            {
                using (c.BeginScope())
                {
                    obj1 = c.GetInstance<ITestA>();
                    obj2 = c.GetInstance<ITestA>();
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
            ITestCase testCase = new PerThreadTestCaseA(new LightInjectRegistration(), new LightInjectResolving());

            var c = new ServiceContainer();
            c = (ServiceContainer)testCase.Register(c, RegistrationKind.PerThread);
            ITestA obj1 = null;
            ITestA obj2 = null;


            var thread1 = new Thread(() =>
            {
                using (c.BeginScope())
                {
                    obj1 = c.GetInstance<ITestA>();
                }
            });
            var thread2 = new Thread(() =>
            {
                using (c.BeginScope())
                {
                    obj2 = c.GetInstance<ITestA>();
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
            ITestCase testCase = new FactoryMethodTestCaseA(new LightInjectRegistration(), new LightInjectResolving());

            var c = new ServiceContainer();
            c = (ServiceContainer)testCase.Register(c, RegistrationKind.FactoryMethod);

            var obj1 = c.GetInstance<ITestA>();
            var obj2 = c.GetInstance<ITestA>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }
    }
}