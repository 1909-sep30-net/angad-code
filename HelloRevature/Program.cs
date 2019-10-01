using System;

namespace HelloRevature
{
    class Program : TestClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Function Call");
            TestClass x = new TestClass();
            x.TestMethod();
        }
    }
}
