using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NiquIoC;
using NiquIoC.Enums;
using PerformanceCalculator.Common;
using PerformanceCalculator.Containers.TestsNiquIoCFull;
using PerformanceCalculator.Interfaces;
using PerformanceCalculator.TestCase.TestCaseD;
using PerformanceCalculator.TestCasesData;

namespace PerformanceCalculator.Tests.Containers.TestsNiquIoCFull
{
    [TestClass]
    public class TestCaseDTests
    {
        [TestMethod]
        public void RegisterSingleton_Success()
        {
            ITestCase testCase = new SingletonTestCaseD(new NiquIoCFullRegistration(), new NiquIoCFullResolving());


            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.Singleton);

            var obj1 = c.Resolve<ITestD>(ResolveKind.FullEmitFunction);
            var obj2 = c.Resolve<ITestD>(ResolveKind.FullEmitFunction);


            CheckHelper.Check(obj1, true, true);
            CheckHelper.Check(obj2, true, true);
            CheckHelper.Check(obj1, obj2, true, true);
        }

        [TestMethod]
        public void RegisterTransient_Success()
        {
            ITestCase testCase = new TransientTestCaseD(new NiquIoCFullRegistration(), new NiquIoCFullResolving());


            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.Transient);

            var obj1 = c.Resolve<ITestD>(ResolveKind.FullEmitFunction);
            var obj2 = c.Resolve<ITestD>(ResolveKind.FullEmitFunction);


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }

        [TestMethod]
        public void RegisterTransientSingleton_Success()
        {
            ITestCase testCase =
                new TransientSingletonTestCaseD(new NiquIoCFullRegistration(), new NiquIoCFullResolving());

            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.TransientSingleton);

            var obj1 = c.Resolve<ITestD>(ResolveKind.FullEmitFunction);
            var obj2 = c.Resolve<ITestD>(ResolveKind.FullEmitFunction);


            CheckHelper.Check(obj1, false, true);
            CheckHelper.Check(obj2, false, true);
            CheckHelper.Check(obj1, obj2, false, true);
        }

        [TestMethod]
        public void RegisterPerThread_SameThread_Success()
        {
            ITestCase testCase = new PerThreadTestCaseD(new NiquIoCFullRegistration(), new NiquIoCFullResolving());

            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.PerThread);
            ITestD obj1 = null;
            ITestD obj2 = null;


            var thread = new Thread(() =>
            {
                obj1 = c.Resolve<ITestD>(ResolveKind.FullEmitFunction);
                obj2 = c.Resolve<ITestD>(ResolveKind.FullEmitFunction);
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
            ITestCase testCase = new PerThreadTestCaseD(new NiquIoCFullRegistration(), new NiquIoCFullResolving());

            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.PerThread);
            ITestD obj1 = null;
            ITestD obj2 = null;


            var thread1 = new Thread(() => { obj1 = c.Resolve<ITestD>(ResolveKind.FullEmitFunction); });
            var thread2 = new Thread(() => { obj2 = c.Resolve<ITestD>(ResolveKind.FullEmitFunction); });
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
            ITestCase testCase = new FactoryMethodTestCaseD(new NiquIoCFullRegistration(), new NiquIoCFullResolving());

            var c = new Container();
            c = (Container)testCase.Register(c, RegistrationKind.FactoryMethod);

            var obj1 = c.Resolve<ITestD>(ResolveKind.FullEmitFunction);
            var obj2 = c.Resolve<ITestD>(ResolveKind.FullEmitFunction);


            CheckHelper.Check(obj1, false, false);
            CheckHelper.Check(obj2, false, false);
            CheckHelper.Check(obj1, obj2, false, false);
        }
    }
}