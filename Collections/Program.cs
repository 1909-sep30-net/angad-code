using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays();
            int a = 1905;
            int b = a;
            b = b / 100;
            Console.WriteLine(b);

        }

        static void Arrays() {

            int[] intArray = new int[5];

            intArray[0] = 3;
            intArray[1] = 5;
            int[] Array2 = new int[] {1, 2, 3, 4}; //Collection Initializer
        }
    }
}
