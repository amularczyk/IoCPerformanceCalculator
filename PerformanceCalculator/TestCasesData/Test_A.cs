namespace PerformanceCalculator.TestCasesData
{
    public interface ITestA0
    {
    }

    public class TestA0 : ITestA0
    {
    }

    public interface ITestA1
    {
        ITestA0 TestA0 { get; }
    }

    public class TestA1 : ITestA1
    {
        public TestA1(ITestA0 testA0)
        {
            TestA0 = testA0;
        }

        public ITestA0 TestA0 { get; }
    }

    public interface ITestA2
    {
        ITestA0 TestA0 { get; }
        ITestA1 TestA1 { get; }
    }

    public class TestA2 : ITestA2
    {
        public TestA2(ITestA0 testA0, ITestA1 testA1)
        {
            TestA0 = testA0;
            TestA1 = testA1;
        }

        public ITestA0 TestA0 { get; }
        public ITestA1 TestA1 { get; }
    }

    public interface ITestA3
    {
        ITestA0 TestA0 { get; }
        ITestA1 TestA1 { get; }
        ITestA2 TestA2 { get; }
    }

    public class TestA3 : ITestA3
    {
        public TestA3(ITestA0 testA0, ITestA1 testA1, ITestA2 testA2)
        {
            TestA0 = testA0;
            TestA1 = testA1;
            TestA2 = testA2;
        }

        public ITestA0 TestA0 { get; }
        public ITestA1 TestA1 { get; }
        public ITestA2 TestA2 { get; }
    }

    public interface ITestA4
    {
        ITestA0 TestA0 { get; }
        ITestA1 TestA1 { get; }
        ITestA2 TestA2 { get; }
        ITestA3 TestA3 { get; }
    }

    public class TestA4 : ITestA4
    {
        public TestA4(ITestA0 testA0, ITestA1 testA1, ITestA2 testA2, ITestA3 testA3)
        {
            TestA0 = testA0;
            TestA1 = testA1;
            TestA2 = testA2;
            TestA3 = testA3;
        }

        public ITestA0 TestA0 { get; }
        public ITestA1 TestA1 { get; }
        public ITestA2 TestA2 { get; }
        public ITestA3 TestA3 { get; }
    }

    public interface ITestA5
    {
        ITestA0 TestA0 { get; }
        ITestA1 TestA1 { get; }
        ITestA2 TestA2 { get; }
        ITestA3 TestA3 { get; }
        ITestA4 TestA4 { get; }
    }

    public class TestA5 : ITestA5
    {
        public TestA5(ITestA0 testA0, ITestA1 testA1, ITestA2 testA2, ITestA3 testA3, ITestA4 testA4)
        {
            TestA0 = testA0;
            TestA1 = testA1;
            TestA2 = testA2;
            TestA3 = testA3;
            TestA4 = testA4;
        }

        public ITestA0 TestA0 { get; }
        public ITestA1 TestA1 { get; }
        public ITestA2 TestA2 { get; }
        public ITestA3 TestA3 { get; }
        public ITestA4 TestA4 { get; }
    }

    public interface ITestA6
    {
        ITestA0 TestA0 { get; }
        ITestA1 TestA1 { get; }
        ITestA2 TestA2 { get; }
        ITestA3 TestA3 { get; }
        ITestA4 TestA4 { get; }
        ITestA5 TestA5 { get; }
    }

    public class TestA6 : ITestA6
    {
        public TestA6(ITestA0 testA0, ITestA1 testA1, ITestA2 testA2, ITestA3 testA3, ITestA4 testA4, ITestA5 testA5)
        {
            TestA0 = testA0;
            TestA1 = testA1;
            TestA2 = testA2;
            TestA3 = testA3;
            TestA4 = testA4;
            TestA5 = testA5;
        }

        public ITestA0 TestA0 { get; }
        public ITestA1 TestA1 { get; }
        public ITestA2 TestA2 { get; }
        public ITestA3 TestA3 { get; }
        public ITestA4 TestA4 { get; }
        public ITestA5 TestA5 { get; }
    }

    public interface ITestA7
    {
        ITestA0 TestA0 { get; }
        ITestA1 TestA1 { get; }
        ITestA2 TestA2 { get; }
        ITestA3 TestA3 { get; }
        ITestA4 TestA4 { get; }
        ITestA5 TestA5 { get; }
        ITestA6 TestA6 { get; }
    }

    public class TestA7 : ITestA7
    {
        public TestA7(ITestA0 testA0, ITestA1 testA1, ITestA2 testA2, ITestA3 testA3, ITestA4 testA4, ITestA5 testA5,
            ITestA6 testA6)
        {
            TestA0 = testA0;
            TestA1 = testA1;
            TestA2 = testA2;
            TestA3 = testA3;
            TestA4 = testA4;
            TestA5 = testA5;
            TestA6 = testA6;
        }

        public ITestA0 TestA0 { get; }
        public ITestA1 TestA1 { get; }
        public ITestA2 TestA2 { get; }
        public ITestA3 TestA3 { get; }
        public ITestA4 TestA4 { get; }
        public ITestA5 TestA5 { get; }
        public ITestA6 TestA6 { get; }
    }

    public interface ITestA8
    {
        ITestA0 TestA0 { get; }
        ITestA1 TestA1 { get; }
        ITestA2 TestA2 { get; }
        ITestA3 TestA3 { get; }
        ITestA4 TestA4 { get; }
        ITestA5 TestA5 { get; }
        ITestA6 TestA6 { get; }
        ITestA7 TestA7 { get; }
    }

    public class TestA8 : ITestA8
    {
        public TestA8(ITestA0 testA0, ITestA1 testA1, ITestA2 testA2, ITestA3 testA3, ITestA4 testA4, ITestA5 testA5,
            ITestA6 testA6,
            ITestA7 testA7)
        {
            TestA0 = testA0;
            TestA1 = testA1;
            TestA2 = testA2;
            TestA3 = testA3;
            TestA4 = testA4;
            TestA5 = testA5;
            TestA6 = testA6;
            TestA7 = testA7;
        }

        public ITestA0 TestA0 { get; }
        public ITestA1 TestA1 { get; }
        public ITestA2 TestA2 { get; }
        public ITestA3 TestA3 { get; }
        public ITestA4 TestA4 { get; }
        public ITestA5 TestA5 { get; }
        public ITestA6 TestA6 { get; }
        public ITestA7 TestA7 { get; }
    }

    public interface ITestA9
    {
        ITestA0 TestA0 { get; }
        ITestA1 TestA1 { get; }
        ITestA2 TestA2 { get; }
        ITestA3 TestA3 { get; }
        ITestA4 TestA4 { get; }
        ITestA5 TestA5 { get; }
        ITestA6 TestA6 { get; }
        ITestA7 TestA7 { get; }
        ITestA8 TestA8 { get; }
    }

    public class TestA9 : ITestA9
    {
        public TestA9(ITestA0 testA0, ITestA1 testA1, ITestA2 testA2, ITestA3 testA3, ITestA4 testA4, ITestA5 testA5,
            ITestA6 testA6,
            ITestA7 testA7, ITestA8 testA8)
        {
            TestA0 = testA0;
            TestA1 = testA1;
            TestA2 = testA2;
            TestA3 = testA3;
            TestA4 = testA4;
            TestA5 = testA5;
            TestA6 = testA6;
            TestA7 = testA7;
            TestA8 = testA8;
        }

        public ITestA0 TestA0 { get; }
        public ITestA1 TestA1 { get; }
        public ITestA2 TestA2 { get; }
        public ITestA3 TestA3 { get; }
        public ITestA4 TestA4 { get; }
        public ITestA5 TestA5 { get; }
        public ITestA6 TestA6 { get; }
        public ITestA7 TestA7 { get; }
        public ITestA8 TestA8 { get; }
    }

    public interface ITestA
    {
        ITestA0 TestA0 { get; }
        ITestA1 TestA1 { get; }
        ITestA2 TestA2 { get; }
        ITestA3 TestA3 { get; }
        ITestA4 TestA4 { get; }
        ITestA5 TestA5 { get; }
        ITestA6 TestA6 { get; }
        ITestA7 TestA7 { get; }
        ITestA8 TestA8 { get; }
        ITestA9 TestA9 { get; }
    }

    public class TestA : ITestA
    {
        public TestA(ITestA0 testA0, ITestA1 testA1, ITestA2 testA2, ITestA3 testA3, ITestA4 testA4, ITestA5 testA5,
            ITestA6 testA6,
            ITestA7 testA7, ITestA8 testA8, ITestA9 testA9)
        {
            TestA0 = testA0;
            TestA1 = testA1;
            TestA2 = testA2;
            TestA3 = testA3;
            TestA4 = testA4;
            TestA5 = testA5;
            TestA6 = testA6;
            TestA7 = testA7;
            TestA8 = testA8;
            TestA9 = testA9;
        }

        public ITestA0 TestA0 { get; }
        public ITestA1 TestA1 { get; }
        public ITestA2 TestA2 { get; }
        public ITestA3 TestA3 { get; }
        public ITestA4 TestA4 { get; }
        public ITestA5 TestA5 { get; }
        public ITestA6 TestA6 { get; }
        public ITestA7 TestA7 { get; }
        public ITestA8 TestA8 { get; }
        public ITestA9 TestA9 { get; }
    }
}