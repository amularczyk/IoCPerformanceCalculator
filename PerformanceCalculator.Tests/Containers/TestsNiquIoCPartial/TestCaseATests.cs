using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NiquIoC;
using NiquIoC.Enums;
using PerformanceCalculator.Common;
using PerformanceCalculator.Containers.TestsNiquIoCPartial;
using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCase.TestCaseA;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.Tests.Containers.TestsNiquIoCPartial
{
    [TestClass]
    public class TestCaseATests
    {
        [TestMethod]
        public void RegisterSingleton_Success()
        {
            ITestCase testCase = new SingletonTestCaseA(new NiquIoCPartialRegistration(),
                new NiquIoCPartialResolving());


            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.Singleton);

            var obj1 = c.Resolve<ITestA>(ResolveKind.PartialEmitFunction);
            var obj2 = c.Resolve<ITestA>(ResolveKind.PartialEmitFunction);


            CheckHelper.Check(obj1, true, true);
            CheckHelper.Check(obj2, true, true);
            CheckHelper.Check(obj1, obj2, true, true);
        }

        [TestMethod]
        public void RegisterTransient_Success()
        {
            ITestCase testCase = new TransientTestCaseA(new NiquIoCPartialRegistration(),
                new NiquIoCPartialResolving());


            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.Transient);

            var obj1 = c.Resolve<ITestA>(ResolveKind.PartialEmitFunction);
            var obj2 = c.Resolve<ITestA>(ResolveKind.PartialEmitFunction);


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }

        [TestMethod]
        public void RegisterTransientSingleton_Success()
        {
            ITestCase testCase =
                new TransientSingletonTestCaseA(new NiquIoCPartialRegistration(), new NiquIoCPartialResolving());

            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.TransientSingleton);

            var obj1 = c.Resolve<ITestA>(ResolveKind.PartialEmitFunction);
            var obj2 = c.Resolve<ITestA>(ResolveKind.PartialEmitFunction);


            CheckHelper.Check(obj1, false, true);
            CheckHelper.Check(obj2, false, true);
            CheckHelper.Check(obj1, obj2, false, true);
        }

        [TestMethod]
        public void RegisterPerThread_SameThread_Success()
        {
            ITestCase testCase = new PerThreadTestCaseA(new NiquIoCPartialRegistration(),
                new NiquIoCPartialResolving());

            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.PerThread);
            ITestA obj1 = null;
            ITestA obj2 = null;


            var thread = new Thread(() =>
            {
                obj1 = c.Resolve<ITestA>(ResolveKind.PartialEmitFunction);
                obj2 = c.Resolve<ITestA>(ResolveKind.PartialEmitFunction);
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
            ITestCase testCase = new PerThreadTestCaseA(new NiquIoCPartialRegistration(),
                new NiquIoCPartialResolving());

            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.PerThread);
            ITestA obj1 = null;
            ITestA obj2 = null;


            var thread1 = new Thread(() => { obj1 = c.Resolve<ITestA>(ResolveKind.PartialEmitFunction); });
            var thread2 = new Thread(() => { obj2 = c.Resolve<ITestA>(ResolveKind.PartialEmitFunction); });
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
            ITestCase testCase = new FactoryMethodTestCaseA(new NiquIoCPartialRegistration(),
                new NiquIoCPartialResolving());

            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.FactoryMethod);

            var obj1 = c.Resolve<ITestA>(ResolveKind.PartialEmitFunction);
            var obj2 = c.Resolve<ITestA>(ResolveKind.PartialEmitFunction);


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }
    }
}