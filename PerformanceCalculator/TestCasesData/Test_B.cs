namespace PerformanceCalculator.TestCasesData
{
    public interface ITestBa0
    {
    }

    public class TestBa0 : ITestBa0
    {
    }

    public interface ITestBa1
    {
        ITestBa0 TestBa0 { get; }
    }

    public class TestBa1 : ITestBa1
    {
        public TestBa1(ITestBa0 testBa0)
        {
            TestBa0 = testBa0;
        }

        public ITestBa0 TestBa0 { get; }
    }

    public interface ITestBa2
    {
        ITestBa0 TestBa0 { get; }
        ITestBa1 TestBa1 { get; }
    }

    public class TestBa2 : ITestBa2
    {
        public TestBa2(ITestBa0 testBa0, ITestBa1 testBa1)
        {
            TestBa0 = testBa0;
            TestBa1 = testBa1;
        }

        public ITestBa0 TestBa0 { get; }
        public ITestBa1 TestBa1 { get; }
    }

    public interface ITestBa3
    {
        ITestBa0 TestBa0 { get; }
        ITestBa1 TestBa1 { get; }
        ITestBa2 TestBa2 { get; }
    }

    public class TestBa3 : ITestBa3
    {
        public TestBa3(ITestBa0 testBa0, ITestBa1 testBa1, ITestBa2 testBa2)
        {
            TestBa0 = testBa0;
            TestBa1 = testBa1;
            TestBa2 = testBa2;
        }

        public ITestBa0 TestBa0 { get; }
        public ITestBa1 TestBa1 { get; }
        public ITestBa2 TestBa2 { get; }
    }

    public interface ITestBa4
    {
        ITestBa0 TestBa0 { get; }
        ITestBa1 TestBa1 { get; }
        ITestBa2 TestBa2 { get; }
        ITestBa3 TestBa3 { get; }
    }

    public class TestBa4 : ITestBa4
    {
        public TestBa4(ITestBa0 testBa0, ITestBa1 testBa1, ITestBa2 testBa2, ITestBa3 testBa3)
        {
            TestBa0 = testBa0;
            TestBa1 = testBa1;
            TestBa2 = testBa2;
            TestBa3 = testBa3;
        }

        public ITestBa0 TestBa0 { get; }
        public ITestBa1 TestBa1 { get; }
        public ITestBa2 TestBa2 { get; }
        public ITestBa3 TestBa3 { get; }
    }

    public interface ITestBa5
    {
        ITestBa0 TestBa0 { get; }
        ITestBa1 TestBa1 { get; }
        ITestBa2 TestBa2 { get; }
        ITestBa3 TestBa3 { get; }
        ITestBa4 TestBa4 { get; }
    }

    public class TestBa5 : ITestBa5
    {
        public TestBa5(ITestBa0 testBa0, ITestBa1 testBa1, ITestBa2 testBa2, ITestBa3 testBa3, ITestBa4 testBa4)
        {
            TestBa0 = testBa0;
            TestBa1 = testBa1;
            TestBa2 = testBa2;
            TestBa3 = testBa3;
            TestBa4 = testBa4;
        }

        public ITestBa0 TestBa0 { get; }
        public ITestBa1 TestBa1 { get; }
        public ITestBa2 TestBa2 { get; }
        public ITestBa3 TestBa3 { get; }
        public ITestBa4 TestBa4 { get; }
    }

    public interface ITestBa6
    {
        ITestBa0 TestBa0 { get; }
        ITestBa1 TestBa1 { get; }
        ITestBa2 TestBa2 { get; }
        ITestBa3 TestBa3 { get; }
        ITestBa4 TestBa4 { get; }
        ITestBa5 TestBa5 { get; }
    }

    public class TestBa6 : ITestBa6
    {
        public TestBa6(ITestBa0 testBa0, ITestBa1 testBa1, ITestBa2 testBa2, ITestBa3 testBa3, ITestBa4 testBa4,
            ITestBa5 testBa5)
        {
            TestBa0 = testBa0;
            TestBa1 = testBa1;
            TestBa2 = testBa2;
            TestBa3 = testBa3;
            TestBa4 = testBa4;
            TestBa5 = testBa5;
        }

        public ITestBa0 TestBa0 { get; }
        public ITestBa1 TestBa1 { get; }
        public ITestBa2 TestBa2 { get; }
        public ITestBa3 TestBa3 { get; }
        public ITestBa4 TestBa4 { get; }
        public ITestBa5 TestBa5 { get; }
    }

    public interface ITestBa7
    {
        ITestBa0 TestBa0 { get; }
        ITestBa1 TestBa1 { get; }
        ITestBa2 TestBa2 { get; }
        ITestBa3 TestBa3 { get; }
        ITestBa4 TestBa4 { get; }
        ITestBa5 TestBa5 { get; }
        ITestBa6 TestBa6 { get; }
    }

    public class TestBa7 : ITestBa7
    {
        public TestBa7(ITestBa0 testBa0, ITestBa1 testBa1, ITestBa2 testBa2, ITestBa3 testBa3, ITestBa4 testBa4,
            ITestBa5 testBa5, ITestBa6 testBa6)
        {
            TestBa0 = testBa0;
            TestBa1 = testBa1;
            TestBa2 = testBa2;
            TestBa3 = testBa3;
            TestBa4 = testBa4;
            TestBa5 = testBa5;
            TestBa6 = testBa6;
        }

        public ITestBa0 TestBa0 { get; }
        public ITestBa1 TestBa1 { get; }
        public ITestBa2 TestBa2 { get; }
        public ITestBa3 TestBa3 { get; }
        public ITestBa4 TestBa4 { get; }
        public ITestBa5 TestBa5 { get; }
        public ITestBa6 TestBa6 { get; }
    }

    public interface ITestBa8
    {
        ITestBa0 TestBa0 { get; }
        ITestBa1 TestBa1 { get; }
        ITestBa2 TestBa2 { get; }
        ITestBa3 TestBa3 { get; }
        ITestBa4 TestBa4 { get; }
        ITestBa5 TestBa5 { get; }
        ITestBa6 TestBa6 { get; }
        ITestBa7 TestBa7 { get; }
    }

    public class TestBa8 : ITestBa8
    {
        public TestBa8(ITestBa0 testBa0, ITestBa1 testBa1, ITestBa2 testBa2, ITestBa3 testBa3, ITestBa4 testBa4,
            ITestBa5 testBa5, ITestBa6 testBa6,
            ITestBa7 testBa7)
        {
            TestBa0 = testBa0;
            TestBa1 = testBa1;
            TestBa2 = testBa2;
            TestBa3 = testBa3;
            TestBa4 = testBa4;
            TestBa5 = testBa5;
            TestBa6 = testBa6;
            TestBa7 = testBa7;
        }

        public ITestBa0 TestBa0 { get; }
        public ITestBa1 TestBa1 { get; }
        public ITestBa2 TestBa2 { get; }
        public ITestBa3 TestBa3 { get; }
        public ITestBa4 TestBa4 { get; }
        public ITestBa5 TestBa5 { get; }
        public ITestBa6 TestBa6 { get; }
        public ITestBa7 TestBa7 { get; }
    }

    public interface ITestBa9
    {
        ITestBa0 TestBa0 { get; }
        ITestBa1 TestBa1 { get; }
        ITestBa2 TestBa2 { get; }
        ITestBa3 TestBa3 { get; }
        ITestBa4 TestBa4 { get; }
        ITestBa5 TestBa5 { get; }
        ITestBa6 TestBa6 { get; }
        ITestBa7 TestBa7 { get; }
        ITestBa8 TestBa8 { get; }
    }

    public class TestBa9 : ITestBa9
    {
        public TestBa9(ITestBa0 testBa0, ITestBa1 testBa1, ITestBa2 testBa2, ITestBa3 testBa3, ITestBa4 testBa4,
            ITestBa5 testBa5, ITestBa6 testBa6,
            ITestBa7 testBa7, ITestBa8 testBa8)
        {
            TestBa0 = testBa0;
            TestBa1 = testBa1;
            TestBa2 = testBa2;
            TestBa3 = testBa3;
            TestBa4 = testBa4;
            TestBa5 = testBa5;
            TestBa6 = testBa6;
            TestBa7 = testBa7;
            TestBa8 = testBa8;
        }

        public ITestBa0 TestBa0 { get; }
        public ITestBa1 TestBa1 { get; }
        public ITestBa2 TestBa2 { get; }
        public ITestBa3 TestBa3 { get; }
        public ITestBa4 TestBa4 { get; }
        public ITestBa5 TestBa5 { get; }
        public ITestBa6 TestBa6 { get; }
        public ITestBa7 TestBa7 { get; }
        public ITestBa8 TestBa8 { get; }
    }

    public interface ITestBa10
    {
        ITestBa0 TestBa0 { get; }
        ITestBa1 TestBa1 { get; }
        ITestBa2 TestBa2 { get; }
        ITestBa3 TestBa3 { get; }
        ITestBa4 TestBa4 { get; }
        ITestBa5 TestBa5 { get; }
        ITestBa6 TestBa6 { get; }
        ITestBa7 TestBa7 { get; }
        ITestBa8 TestBa8 { get; }
        ITestBa9 TestBa9 { get; }
    }

    public class TestBa10 : ITestBa10
    {
        public TestBa10(ITestBa0 testBa0, ITestBa1 testBa1, ITestBa2 testBa2, ITestBa3 testBa3, ITestBa4 testBa4,
            ITestBa5 testBa5, ITestBa6 testBa6,
            ITestBa7 testBa7, ITestBa8 testBa8, ITestBa9 testBa9)
        {
            TestBa0 = testBa0;
            TestBa1 = testBa1;
            TestBa2 = testBa2;
            TestBa3 = testBa3;
            TestBa4 = testBa4;
            TestBa5 = testBa5;
            TestBa6 = testBa6;
            TestBa7 = testBa7;
            TestBa8 = testBa8;
            TestBa9 = testBa9;
        }

        public ITestBa0 TestBa0 { get; }
        public ITestBa1 TestBa1 { get; }
        public ITestBa2 TestBa2 { get; }
        public ITestBa3 TestBa3 { get; }
        public ITestBa4 TestBa4 { get; }
        public ITestBa5 TestBa5 { get; }
        public ITestBa6 TestBa6 { get; }
        public ITestBa7 TestBa7 { get; }
        public ITestBa8 TestBa8 { get; }
        public ITestBa9 TestBa9 { get; }
    }


    public interface ITestBb0
    {
    }

    public class TestBb0 : ITestBb0
    {
    }

    public interface ITestBb1
    {
        ITestBb0 TestBb0 { get; }
    }

    public class TestBb1 : ITestBb1
    {
        public TestBb1(ITestBb0 testBb0)
        {
            TestBb0 = testBb0;
        }

        public ITestBb0 TestBb0 { get; }
    }

    public interface ITestBb2
    {
        ITestBb0 TestBb0 { get; }
        ITestBb1 TestBb1 { get; }
    }

    public class TestBb2 : ITestBb2
    {
        public TestBb2(ITestBb0 testBb0, ITestBb1 testBb1)
        {
            TestBb0 = testBb0;
            TestBb1 = testBb1;
        }

        public ITestBb0 TestBb0 { get; }
        public ITestBb1 TestBb1 { get; }
    }

    public interface ITestBb3
    {
        ITestBb0 TestBb0 { get; }
        ITestBb1 TestBb1 { get; }
        ITestBb2 TestBb2 { get; }
    }

    public class TestBb3 : ITestBb3
    {
        public TestBb3(ITestBb0 testBb0, ITestBb1 testBb1, ITestBb2 testBb2)
        {
            TestBb0 = testBb0;
            TestBb1 = testBb1;
            TestBb2 = testBb2;
        }

        public ITestBb0 TestBb0 { get; }
        public ITestBb1 TestBb1 { get; }
        public ITestBb2 TestBb2 { get; }
    }

    public interface ITestBb4
    {
        ITestBb0 TestBb0 { get; }
        ITestBb1 TestBb1 { get; }
        ITestBb2 TestBb2 { get; }
        ITestBb3 TestBb3 { get; }
    }

    public class TestBb4 : ITestBb4
    {
        public TestBb4(ITestBb0 testBb0, ITestBb1 testBb1, ITestBb2 testBb2, ITestBb3 testBb3)
        {
            TestBb0 = testBb0;
            TestBb1 = testBb1;
            TestBb2 = testBb2;
            TestBb3 = testBb3;
        }

        public ITestBb0 TestBb0 { get; }
        public ITestBb1 TestBb1 { get; }
        public ITestBb2 TestBb2 { get; }
        public ITestBb3 TestBb3 { get; }
    }

    public interface ITestBb5
    {
        ITestBb0 TestBb0 { get; }
        ITestBb1 TestBb1 { get; }
        ITestBb2 TestBb2 { get; }
        ITestBb3 TestBb3 { get; }
        ITestBb4 TestBb4 { get; }
    }

    public class TestBb5 : ITestBb5
    {
        public TestBb5(ITestBb0 testBb0, ITestBb1 testBb1, ITestBb2 testBb2, ITestBb3 testBb3, ITestBb4 testBb4)
        {
            TestBb0 = testBb0;
            TestBb1 = testBb1;
            TestBb2 = testBb2;
            TestBb3 = testBb3;
            TestBb4 = testBb4;
        }

        public ITestBb0 TestBb0 { get; }
        public ITestBb1 TestBb1 { get; }
        public ITestBb2 TestBb2 { get; }
        public ITestBb3 TestBb3 { get; }
        public ITestBb4 TestBb4 { get; }
    }

    public interface ITestBb6
    {
        ITestBb0 TestBb0 { get; }
        ITestBb1 TestBb1 { get; }
        ITestBb2 TestBb2 { get; }
        ITestBb3 TestBb3 { get; }
        ITestBb4 TestBb4 { get; }
        ITestBb5 TestBb5 { get; }
    }

    public class TestBb6 : ITestBb6
    {
        public TestBb6(ITestBb0 testBb0, ITestBb1 testBb1, ITestBb2 testBb2, ITestBb3 testBb3, ITestBb4 testBb4,
            ITestBb5 testBb5)
        {
            TestBb0 = testBb0;
            TestBb1 = testBb1;
            TestBb2 = testBb2;
            TestBb3 = testBb3;
            TestBb4 = testBb4;
            TestBb5 = testBb5;
        }

        public ITestBb0 TestBb0 { get; }
        public ITestBb1 TestBb1 { get; }
        public ITestBb2 TestBb2 { get; }
        public ITestBb3 TestBb3 { get; }
        public ITestBb4 TestBb4 { get; }
        public ITestBb5 TestBb5 { get; }
    }

    public interface ITestBb7
    {
        ITestBb0 TestBb0 { get; }
        ITestBb1 TestBb1 { get; }
        ITestBb2 TestBb2 { get; }
        ITestBb3 TestBb3 { get; }
        ITestBb4 TestBb4 { get; }
        ITestBb5 TestBb5 { get; }
        ITestBb6 TestBb6 { get; }
    }

    public class TestBb7 : ITestBb7
    {
        public TestBb7(ITestBb0 testBb0, ITestBb1 testBb1, ITestBb2 testBb2, ITestBb3 testBb3, ITestBb4 testBb4,
            ITestBb5 testBb5, ITestBb6 testBb6)
        {
            TestBb0 = testBb0;
            TestBb1 = testBb1;
            TestBb2 = testBb2;
            TestBb3 = testBb3;
            TestBb4 = testBb4;
            TestBb5 = testBb5;
            TestBb6 = testBb6;
        }

        public ITestBb0 TestBb0 { get; }
        public ITestBb1 TestBb1 { get; }
        public ITestBb2 TestBb2 { get; }
        public ITestBb3 TestBb3 { get; }
        public ITestBb4 TestBb4 { get; }
        public ITestBb5 TestBb5 { get; }
        public ITestBb6 TestBb6 { get; }
    }

    public interface ITestBb8
    {
        ITestBb0 TestBb0 { get; }
        ITestBb1 TestBb1 { get; }
        ITestBb2 TestBb2 { get; }
        ITestBb3 TestBb3 { get; }
        ITestBb4 TestBb4 { get; }
        ITestBb5 TestBb5 { get; }
        ITestBb6 TestBb6 { get; }
        ITestBb7 TestBb7 { get; }
    }

    public class TestBb8 : ITestBb8
    {
        public TestBb8(ITestBb0 testBb0, ITestBb1 testBb1, ITestBb2 testBb2, ITestBb3 testBb3, ITestBb4 testBb4,
            ITestBb5 testBb5, ITestBb6 testBb6,
            ITestBb7 testBb7)
        {
            TestBb0 = testBb0;
            TestBb1 = testBb1;
            TestBb2 = testBb2;
            TestBb3 = testBb3;
            TestBb4 = testBb4;
            TestBb5 = testBb5;
            TestBb6 = testBb6;
            TestBb7 = testBb7;
        }

        public ITestBb0 TestBb0 { get; }
        public ITestBb1 TestBb1 { get; }
        public ITestBb2 TestBb2 { get; }
        public ITestBb3 TestBb3 { get; }
        public ITestBb4 TestBb4 { get; }
        public ITestBb5 TestBb5 { get; }
        public ITestBb6 TestBb6 { get; }
        public ITestBb7 TestBb7 { get; }
    }

    public interface ITestBb9
    {
        ITestBb0 TestBb0 { get; }
        ITestBb1 TestBb1 { get; }
        ITestBb2 TestBb2 { get; }
        ITestBb3 TestBb3 { get; }
        ITestBb4 TestBb4 { get; }
        ITestBb5 TestBb5 { get; }
        ITestBb6 TestBb6 { get; }
        ITestBb7 TestBb7 { get; }
        ITestBb8 TestBb8 { get; }
    }

    public class TestBb9 : ITestBb9
    {
        public TestBb9(ITestBb0 testBb0, ITestBb1 testBb1, ITestBb2 testBb2, ITestBb3 testBb3, ITestBb4 testBb4,
            ITestBb5 testBb5, ITestBb6 testBb6,
            ITestBb7 testBb7, ITestBb8 testBb8)
        {
            TestBb0 = testBb0;
            TestBb1 = testBb1;
            TestBb2 = testBb2;
            TestBb3 = testBb3;
            TestBb4 = testBb4;
            TestBb5 = testBb5;
            TestBb6 = testBb6;
            TestBb7 = testBb7;
            TestBb8 = testBb8;
        }

        public ITestBb0 TestBb0 { get; }
        public ITestBb1 TestBb1 { get; }
        public ITestBb2 TestBb2 { get; }
        public ITestBb3 TestBb3 { get; }
        public ITestBb4 TestBb4 { get; }
        public ITestBb5 TestBb5 { get; }
        public ITestBb6 TestBb6 { get; }
        public ITestBb7 TestBb7 { get; }
        public ITestBb8 TestBb8 { get; }
    }

    public interface ITestBb10
    {
        ITestBb0 TestBb0 { get; }
        ITestBb1 TestBb1 { get; }
        ITestBb2 TestBb2 { get; }
        ITestBb3 TestBb3 { get; }
        ITestBb4 TestBb4 { get; }
        ITestBb5 TestBb5 { get; }
        ITestBb6 TestBb6 { get; }
        ITestBb7 TestBb7 { get; }
        ITestBb8 TestBb8 { get; }
        ITestBb9 TestBb9 { get; }
    }

    public class TestBb10 : ITestBb10
    {
        public TestBb10(ITestBb0 testBb0, ITestBb1 testBb1, ITestBb2 testBb2, ITestBb3 testBb3, ITestBb4 testBb4,
            ITestBb5 testBb5, ITestBb6 testBb6,
            ITestBb7 testBb7, ITestBb8 testBb8, ITestBb9 testBb9)
        {
            TestBb0 = testBb0;
            TestBb1 = testBb1;
            TestBb2 = testBb2;
            TestBb3 = testBb3;
            TestBb4 = testBb4;
            TestBb5 = testBb5;
            TestBb6 = testBb6;
            TestBb7 = testBb7;
            TestBb8 = testBb8;
            TestBb9 = testBb9;
        }

        public ITestBb0 TestBb0 { get; }
        public ITestBb1 TestBb1 { get; }
        public ITestBb2 TestBb2 { get; }
        public ITestBb3 TestBb3 { get; }
        public ITestBb4 TestBb4 { get; }
        public ITestBb5 TestBb5 { get; }
        public ITestBb6 TestBb6 { get; }
        public ITestBb7 TestBb7 { get; }
        public ITestBb8 TestBb8 { get; }
        public ITestBb9 TestBb9 { get; }
    }


    public interface ITestBc0
    {
    }

    public class TestBc0 : ITestBc0
    {
    }

    public interface ITestBc1
    {
        ITestBc0 TestBc0 { get; }
    }

    public class TestBc1 : ITestBc1
    {
        public TestBc1(ITestBc0 testBc0)
        {
            TestBc0 = testBc0;
        }

        public ITestBc0 TestBc0 { get; }
    }

    public interface ITestBc2
    {
        ITestBc0 TestBc0 { get; }
        ITestBc1 TestBc1 { get; }
    }

    public class TestBc2 : ITestBc2
    {
        public TestBc2(ITestBc0 testBc0, ITestBc1 testBc1)
        {
            TestBc0 = testBc0;
            TestBc1 = testBc1;
        }

        public ITestBc0 TestBc0 { get; }
        public ITestBc1 TestBc1 { get; }
    }

    public interface ITestBc3
    {
        ITestBc0 TestBc0 { get; }
        ITestBc1 TestBc1 { get; }
        ITestBc2 TestBc2 { get; }
    }

    public class TestBc3 : ITestBc3
    {
        public TestBc3(ITestBc0 testBc0, ITestBc1 testBc1, ITestBc2 testBc2)
        {
            TestBc0 = testBc0;
            TestBc1 = testBc1;
            TestBc2 = testBc2;
        }

        public ITestBc0 TestBc0 { get; }
        public ITestBc1 TestBc1 { get; }
        public ITestBc2 TestBc2 { get; }
    }

    public interface ITestBc4
    {
        ITestBc0 TestBc0 { get; }
        ITestBc1 TestBc1 { get; }
        ITestBc2 TestBc2 { get; }
        ITestBc3 TestBc3 { get; }
    }

    public class TestBc4 : ITestBc4
    {
        public TestBc4(ITestBc0 testBc0, ITestBc1 testBc1, ITestBc2 testBc2, ITestBc3 testBc3)
        {
            TestBc0 = testBc0;
            TestBc1 = testBc1;
            TestBc2 = testBc2;
            TestBc3 = testBc3;
        }

        public ITestBc0 TestBc0 { get; }
        public ITestBc1 TestBc1 { get; }
        public ITestBc2 TestBc2 { get; }
        public ITestBc3 TestBc3 { get; }
    }

    public interface ITestBc5
    {
        ITestBc0 TestBc0 { get; }
        ITestBc1 TestBc1 { get; }
        ITestBc2 TestBc2 { get; }
        ITestBc3 TestBc3 { get; }
        ITestBc4 TestBc4 { get; }
    }

    public class TestBc5 : ITestBc5
    {
        public TestBc5(ITestBc0 testBc0, ITestBc1 testBc1, ITestBc2 testBc2, ITestBc3 testBc3, ITestBc4 testBc4)
        {
            TestBc0 = testBc0;
            TestBc1 = testBc1;
            TestBc2 = testBc2;
            TestBc3 = testBc3;
            TestBc4 = testBc4;
        }

        public ITestBc0 TestBc0 { get; }
        public ITestBc1 TestBc1 { get; }
        public ITestBc2 TestBc2 { get; }
        public ITestBc3 TestBc3 { get; }
        public ITestBc4 TestBc4 { get; }
    }

    public interface ITestBc6
    {
        ITestBc0 TestBc0 { get; }
        ITestBc1 TestBc1 { get; }
        ITestBc2 TestBc2 { get; }
        ITestBc3 TestBc3 { get; }
        ITestBc4 TestBc4 { get; }
        ITestBc5 TestBc5 { get; }
    }

    public class TestBc6 : ITestBc6
    {
        public TestBc6(ITestBc0 testBc0, ITestBc1 testBc1, ITestBc2 testBc2, ITestBc3 testBc3, ITestBc4 testBc4,
            ITestBc5 testBc5)
        {
            TestBc0 = testBc0;
            TestBc1 = testBc1;
            TestBc2 = testBc2;
            TestBc3 = testBc3;
            TestBc4 = testBc4;
            TestBc5 = testBc5;
        }

        public ITestBc0 TestBc0 { get; }
        public ITestBc1 TestBc1 { get; }
        public ITestBc2 TestBc2 { get; }
        public ITestBc3 TestBc3 { get; }
        public ITestBc4 TestBc4 { get; }
        public ITestBc5 TestBc5 { get; }
    }

    public interface ITestBc7
    {
        ITestBc0 TestBc0 { get; }
        ITestBc1 TestBc1 { get; }
        ITestBc2 TestBc2 { get; }
        ITestBc3 TestBc3 { get; }
        ITestBc4 TestBc4 { get; }
        ITestBc5 TestBc5 { get; }
        ITestBc6 TestBc6 { get; }
    }

    public class TestBc7 : ITestBc7
    {
        public TestBc7(ITestBc0 testBc0, ITestBc1 testBc1, ITestBc2 testBc2, ITestBc3 testBc3, ITestBc4 testBc4,
            ITestBc5 testBc5, ITestBc6 testBc6)
        {
            TestBc0 = testBc0;
            TestBc1 = testBc1;
            TestBc2 = testBc2;
            TestBc3 = testBc3;
            TestBc4 = testBc4;
            TestBc5 = testBc5;
            TestBc6 = testBc6;
        }

        public ITestBc0 TestBc0 { get; }
        public ITestBc1 TestBc1 { get; }
        public ITestBc2 TestBc2 { get; }
        public ITestBc3 TestBc3 { get; }
        public ITestBc4 TestBc4 { get; }
        public ITestBc5 TestBc5 { get; }
        public ITestBc6 TestBc6 { get; }
    }

    public interface ITestBc8
    {
        ITestBc0 TestBc0 { get; }
        ITestBc1 TestBc1 { get; }
        ITestBc2 TestBc2 { get; }
        ITestBc3 TestBc3 { get; }
        ITestBc4 TestBc4 { get; }
        ITestBc5 TestBc5 { get; }
        ITestBc6 TestBc6 { get; }
        ITestBc7 TestBc7 { get; }
    }

    public class TestBc8 : ITestBc8
    {
        public TestBc8(ITestBc0 testBc0, ITestBc1 testBc1, ITestBc2 testBc2, ITestBc3 testBc3, ITestBc4 testBc4,
            ITestBc5 testBc5, ITestBc6 testBc6,
            ITestBc7 testBc7)
        {
            TestBc0 = testBc0;
            TestBc1 = testBc1;
            TestBc2 = testBc2;
            TestBc3 = testBc3;
            TestBc4 = testBc4;
            TestBc5 = testBc5;
            TestBc6 = testBc6;
            TestBc7 = testBc7;
        }

        public ITestBc0 TestBc0 { get; }
        public ITestBc1 TestBc1 { get; }
        public ITestBc2 TestBc2 { get; }
        public ITestBc3 TestBc3 { get; }
        public ITestBc4 TestBc4 { get; }
        public ITestBc5 TestBc5 { get; }
        public ITestBc6 TestBc6 { get; }
        public ITestBc7 TestBc7 { get; }
    }

    public interface ITestBc9
    {
        ITestBc0 TestBc0 { get; }
        ITestBc1 TestBc1 { get; }
        ITestBc2 TestBc2 { get; }
        ITestBc3 TestBc3 { get; }
        ITestBc4 TestBc4 { get; }
        ITestBc5 TestBc5 { get; }
        ITestBc6 TestBc6 { get; }
        ITestBc7 TestBc7 { get; }
        ITestBc8 TestBc8 { get; }
    }

    public class TestBc9 : ITestBc9
    {
        public TestBc9(ITestBc0 testBc0, ITestBc1 testBc1, ITestBc2 testBc2, ITestBc3 testBc3, ITestBc4 testBc4,
            ITestBc5 testBc5, ITestBc6 testBc6,
            ITestBc7 testBc7, ITestBc8 testBc8)
        {
            TestBc0 = testBc0;
            TestBc1 = testBc1;
            TestBc2 = testBc2;
            TestBc3 = testBc3;
            TestBc4 = testBc4;
            TestBc5 = testBc5;
            TestBc6 = testBc6;
            TestBc7 = testBc7;
            TestBc8 = testBc8;
        }

        public ITestBc0 TestBc0 { get; }
        public ITestBc1 TestBc1 { get; }
        public ITestBc2 TestBc2 { get; }
        public ITestBc3 TestBc3 { get; }
        public ITestBc4 TestBc4 { get; }
        public ITestBc5 TestBc5 { get; }
        public ITestBc6 TestBc6 { get; }
        public ITestBc7 TestBc7 { get; }
        public ITestBc8 TestBc8 { get; }
    }

    public interface ITestBc10
    {
        ITestBc0 TestBc0 { get; }
        ITestBc1 TestBc1 { get; }
        ITestBc2 TestBc2 { get; }
        ITestBc3 TestBc3 { get; }
        ITestBc4 TestBc4 { get; }
        ITestBc5 TestBc5 { get; }
        ITestBc6 TestBc6 { get; }
        ITestBc7 TestBc7 { get; }
        ITestBc8 TestBc8 { get; }
        ITestBc9 TestBc9 { get; }
    }

    public class TestBc10 : ITestBc10
    {
        public TestBc10(ITestBc0 testBc0, ITestBc1 testBc1, ITestBc2 testBc2, ITestBc3 testBc3, ITestBc4 testBc4,
            ITestBc5 testBc5, ITestBc6 testBc6,
            ITestBc7 testBc7, ITestBc8 testBc8, ITestBc9 testBc9)
        {
            TestBc0 = testBc0;
            TestBc1 = testBc1;
            TestBc2 = testBc2;
            TestBc3 = testBc3;
            TestBc4 = testBc4;
            TestBc5 = testBc5;
            TestBc6 = testBc6;
            TestBc7 = testBc7;
            TestBc8 = testBc8;
            TestBc9 = testBc9;
        }

        public ITestBc0 TestBc0 { get; }
        public ITestBc1 TestBc1 { get; }
        public ITestBc2 TestBc2 { get; }
        public ITestBc3 TestBc3 { get; }
        public ITestBc4 TestBc4 { get; }
        public ITestBc5 TestBc5 { get; }
        public ITestBc6 TestBc6 { get; }
        public ITestBc7 TestBc7 { get; }
        public ITestBc8 TestBc8 { get; }
        public ITestBc9 TestBc9 { get; }
    }


    public interface ITestB
    {
        ITestBa10 TestBa10 { get; }
        ITestBb10 TestBb10 { get; }
        ITestBc10 TestBc10 { get; }
    }

    public class TestB : ITestB
    {
        public TestB(ITestBa10 testBa10, ITestBb10 testBb10, ITestBc10 testBc10)
        {
            TestBa10 = testBa10;
            TestBb10 = testBb10;
            TestBc10 = testBc10;
        }

        public ITestBa10 TestBa10 { get; }
        public ITestBb10 TestBb10 { get; }
        public ITestBc10 TestBc10 { get; }
    }
}