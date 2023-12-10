namespace LambdaTest2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int testName = 5;
            Action showMethod = () => { ++testName; Console.WriteLine(testName); };
            Action showMethod2 = () => { Console.WriteLine(testName); };
            Action showMethod3 = () => { Console.WriteLine(testName); };
            Action showMethod4 = () => { Console.WriteLine(testName); };
            Action showMethod5 = () => { Console.WriteLine(testName); };
            Action showMethod6 = () => { Console.WriteLine(testName); };
            Action showMethod7 = () => { Console.WriteLine(testName); };
            Action showMethod8 = () => { Console.WriteLine(testName); };
            Action showMethod9 = () => { Console.WriteLine(testName); };
            showMethod();
            showMethod2();
        }
    }
}
