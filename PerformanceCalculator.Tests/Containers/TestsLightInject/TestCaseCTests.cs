using System.Threading;
using LightInject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerformanceCalculator.Common;
using PerformanceCalculator.Containers.TestsLightInject;
using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCase.TestCaseC;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.Tests.Containers.TestsLightInject
{
    [TestClass]
    public class TestCaseCTests
    {
        [TestMethod]
        public void RegisterSingleton_Success()
        {
            ITestCase testCase = new SingletonTestCaseC(new LightInjectRegistration(), new LightInjectResolving());


            var c = new ServiceContainer();
            c = (ServiceContainer)testCase.Register(c, RegistrationKind.Singleton);

            var obj1 = c.GetInstance<ITestC>();
            var obj2 = c.GetInstance<ITestC>();


            CheckHelper.Check(obj1, true, true);
            CheckHelper.Check(obj2, true, true);
            CheckHelper.Check(obj1, obj2, true, true);
        }

        [TestMethod]
        public void RegisterTransient_Success()
        {
            ITestCase testCase = new TransientTestCaseC(new LightInjectRegistration(), new LightInjectResolving());


            var c = new ServiceContainer();
            c = (ServiceContainer)testCase.Register(c, RegistrationKind.Transient);

            var obj1 = c.GetInstance<ITestC>();
            var obj2 = c.GetInstance<ITestC>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }

        [TestMethod]
        public void RegisterTransientSingleton_Success()
        {
            ITestCase testCase =
                new TransientSingletonTestCaseC(new LightInjectRegistration(), new LightInjectResolving());

            var c = new ServiceContainer();
            c = (ServiceContainer)testCase.Register(c, RegistrationKind.TransientSingleton);

            var obj1 = c.GetInstance<ITestC>();
            var obj2 = c.GetInstance<ITestC>();


            CheckHelper.Check(obj1, false, true);
            CheckHelper.Check(obj2, false, true);
            CheckHelper.Check(obj1, obj2, false, true);
        }

        [TestMethod]
        public void RegisterPerThread_SameThread_Success()
        {
            ITestCase testCase = new PerThreadTestCaseC(new LightInjectRegistration(), new LightInjectResolving());

            var c = new ServiceContainer();
            c = (ServiceContainer)testCase.Register(c, RegistrationKind.PerThread);
            ITestC obj1 = null;
            ITestC obj2 = null;


            var thread = new Thread(() =>
            {
                using (c.BeginScope())
                {
                    obj1 = c.GetInstance<ITestC>();
                    obj2 = c.GetInstance<ITestC>();
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
            ITestCase testCase = new PerThreadTestCaseC(new LightInjectRegistration(), new LightInjectResolving());

            var c = new ServiceContainer();
            c = (ServiceContainer)testCase.Register(c, RegistrationKind.PerThread);
            ITestC obj1 = null;
            ITestC obj2 = null;


            var thread1 = new Thread(() =>
            {
                using (c.BeginScope())
                {
                    obj1 = c.GetInstance<ITestC>();
                }
            });
            var thread2 = new Thread(() =>
            {
                using (c.BeginScope())
                {
                    obj2 = c.GetInstance<ITestC>();
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
            ITestCase testCase = new FactoryMethodTestCaseC(new LightInjectRegistration(), new LightInjectResolving());

            var c = new ServiceContainer();
            c = (ServiceContainer)testCase.Register(c, RegistrationKind.FactoryMethod);

            var obj1 = c.GetInstance<ITestC>();
            var obj2 = c.GetInstance<ITestC>();


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }
    }
}