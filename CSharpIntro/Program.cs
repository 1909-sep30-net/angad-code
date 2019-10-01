using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // make bool, string, and int variables (with values)

            // change their values to something else

            // print their values with Console

            // do something in a for loop
            // do something in a while loop
            // do something with a switch statement

            // do something with if, else if, else

            // figure out how to make multi-line comments in C#
            // figure out how to format your document in VS Code

            // extra: make a new static method to do something and call it
            // extra: learn what "var" means in C# and try it out.
            
            Console.Clear();

            //Declaring Variables
            int a = 10;
            bool b = true;
            string c = "Test";

            Console.WriteLine("Inital Values");
            Console.Write(a + " ");
            Console.Write(b + " ");
            Console.Write(c + "\n");

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
            Console.Clear();

            //Changing Variables
            a = 20;
            b = false;
            c = "DifferentTest";
            
            Console.WriteLine("Changed Values");
            Console.Write(a + " ");
            Console.Write(b + " ");
            Console.Write(c + "\n");

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
            Console.Clear();
            
            //For Loop
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Printing Line {0} using For Loop", i);
            }

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
            Console.Clear();

            //While Loop
            int whileVar = 0;
            while(whileVar < 10) {
                whileVar++;
                Console.WriteLine("While Loop {0}", whileVar);
            }

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
            Console.Clear();

            //Switch Case
            int switchVar = 0;
            Console.WriteLine("Please Enter a Value");
            switchVar = Console.Read();
            
            switch(switchVar) {
                case 0:
                    Console.WriteLine("You entered 0 | Switch");
                    break;
                case 1:
                    Console.WriteLine("You Entered 1 | Switch");
                    break;
                default:
                    Console.WriteLine("You entered neither 0 nor 1 | Switch");
                    break;
            }

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
            Console.Clear();

            int ifVar = 0;
            Console.WriteLine("Enter A Number: ");
            ifVar = Console.Read();

            if(ifVar == 0) {
                Console.WriteLine("Neither Even Nor Odd");
            }
            else if(ifVar % 2 == 0) {
                Console.WriteLine("Even");
            }
            else {
                Console.WriteLine("Odd");
            }

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
            Console.Clear();

            /* Multi Line
            Comments */

        }
    }
}
