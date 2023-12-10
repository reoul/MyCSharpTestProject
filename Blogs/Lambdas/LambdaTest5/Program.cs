namespace LambdaTest5
{
    public class TestClass
    {
        int i = 256;
        double d = 135.513;

        public void Test()
        {
            Action showMethod1 = () => { Console.WriteLine(d += 123.456); Console.WriteLine(++Program.staticInt); };
            Action showMethod2 = () => { Console.WriteLine(showMethod1); Console.WriteLine(++i); };
            Action showMethod3 = () => { Console.WriteLine(d += 123.456); Console.WriteLine(showMethod2); Console.WriteLine(showMethod2); };
            Action showMethod4 = () => { Console.WriteLine(TestClass222.staticDouble += 12.45); Console.WriteLine(d += 123.456); };
            showMethod1();
            showMethod2();
            showMethod3();
            showMethod4();
        }
    }

    public class TestClass222
    {
        public static double staticDouble = 123.456;
    }

    public class Program
    {
        public static int staticInt = 132;
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            test.Test();
        }
    }
}
