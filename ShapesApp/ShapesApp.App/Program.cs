using System;
using ShapesApp.Library;

namespace ShapesApp.App
{
    static class Program 
    {
        static void Main(string[] args)
        {
            
            double length, width;
            string input;

            do {

                Console.WriteLine("Enter a length: ");
                input = Console.ReadLine();

            }
            while(double.TryParse(input, out length));

            do {

                Console.WriteLine("Enter a Width: ");
                input = Console.ReadLine();

            }
            while(double.TryParse(input, out width));

            //Similar to ollection Initalizer, We have a Property Initializer

            /*var r = new Rectangle();
            r.Length = length;
            r.Width = width;*/

            var rectangle = new Rectangle {
                Length = length,
                Width = width
            };

            PrintRectangle(rectangle);

        }
        public static void PrintRectangle(Rectangle r) {
                Console.WriteLine($"{r.Length} x {r.Width} rectangle");
        }
        
    }
}
