namespace LambdaTest6
{
    public class TestClass
    {
        public void Test()
        {
            Action showMethod1 = () => { Console.WriteLine(); };
            showMethod1();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            test.Test();

            Action showMethod1 = () => { Console.WriteLine(); };
            showMethod1();
        }
    }
}
