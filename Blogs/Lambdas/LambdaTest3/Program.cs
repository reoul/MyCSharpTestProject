namespace LambdaTest3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 256;
            string s = "string";
            double d = 135.513;
            Action showMethod1 = () => { Console.WriteLine(i); };
            Action showMethod2 = () => { Console.WriteLine(s); Console.WriteLine(++i); };
            Action showMethod3 = () => { Console.WriteLine(d += 123.456); Console.WriteLine(s += "add"); Console.WriteLine(++i); };
            showMethod1();
            showMethod2();
            showMethod3();
            showMethod3();
            showMethod2();
            showMethod1();
        }
    }
}
