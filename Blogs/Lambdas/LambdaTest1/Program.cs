
namespace LambdaTest1
{
    public class Name
    {
        private string instanceName;

        public Name(string name)
        {
            this.instanceName = name;
        }

        public void DisplayToWindow()
        {
            Console.WriteLine(this.instanceName);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Name testName = new Name("Koani");
            Action showMethod = () => testName.DisplayToWindow();
            showMethod();
        }
    }
}
