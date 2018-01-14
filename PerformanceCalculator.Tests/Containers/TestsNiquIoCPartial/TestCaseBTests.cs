using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NiquIoC;
using NiquIoC.Enums;
using PerformanceCalculator.Common;
using PerformanceCalculator.Containers.TestsNiquIoCPartial;
using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCase.TestCaseB;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.Tests.Containers.TestsNiquIoCPartial
{
    [TestClass]
    public class TestCaseBTests
    {
        [TestMethod]
        public void RegisterSingleton_Success()
        {
            ITestCase testCase = new SingletonTestCaseB(new NiquIoCPartialRegistration(),
                new NiquIoCPartialResolving());


            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.Singleton);

            var obj1 = c.Resolve<ITestB>(ResolveKind.PartialEmitFunction);
            var obj2 = c.Resolve<ITestB>(ResolveKind.PartialEmitFunction);


            CheckHelper.Check(obj1, true, true);
            CheckHelper.Check(obj2, true, true);
            CheckHelper.Check(obj1, obj2, true, true);
        }

        [TestMethod]
        public void RegisterTransient_Success()
        {
            ITestCase testCase = new TransientTestCaseB(new NiquIoCPartialRegistration(),
                new NiquIoCPartialResolving());


            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.Transient);

            var obj1 = c.Resolve<ITestB>(ResolveKind.PartialEmitFunction);
            var obj2 = c.Resolve<ITestB>(ResolveKind.PartialEmitFunction);


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }

        [TestMethod]
        public void RegisterTransientSingleton_Success()
        {
            ITestCase testCase =
                new TransientSingletonTestCaseB(new NiquIoCPartialRegistration(), new NiquIoCPartialResolving());

            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.TransientSingleton);

            var obj1 = c.Resolve<ITestB>(ResolveKind.PartialEmitFunction);
            var obj2 = c.Resolve<ITestB>(ResolveKind.PartialEmitFunction);


            CheckHelper.Check(obj1, false, true);
            CheckHelper.Check(obj2, false, true);
            CheckHelper.Check(obj1, obj2, false, true);
        }

        [TestMethod]
        public void RegisterPerThread_SameThread_Success()
        {
            ITestCase testCase = new PerThreadTestCaseB(new NiquIoCPartialRegistration(),
                new NiquIoCPartialResolving());

            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.PerThread);
            ITestB obj1 = null;
            ITestB obj2 = null;


            var thread = new Thread(() =>
            {
                obj1 = c.Resolve<ITestB>(ResolveKind.PartialEmitFunction);
                obj2 = c.Resolve<ITestB>(ResolveKind.PartialEmitFunction);
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
            ITestCase testCase = new PerThreadTestCaseB(new NiquIoCPartialRegistration(),
                new NiquIoCPartialResolving());

            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.PerThread);
            ITestB obj1 = null;
            ITestB obj2 = null;


            var thread1 = new Thread(() => { obj1 = c.Resolve<ITestB>(ResolveKind.PartialEmitFunction); });
            var thread2 = new Thread(() => { obj2 = c.Resolve<ITestB>(ResolveKind.PartialEmitFunction); });
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
            ITestCase testCase = new FactoryMethodTestCaseB(new NiquIoCPartialRegistration(),
                new NiquIoCPartialResolving());

            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.FactoryMethod);

            var obj1 = c.Resolve<ITestB>(ResolveKind.PartialEmitFunction);
            var obj2 = c.Resolve<ITestB>(ResolveKind.PartialEmitFunction);


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }
    }
}