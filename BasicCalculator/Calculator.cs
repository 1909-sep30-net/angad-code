using System;
using System.Collections.Generic;

namespace BasicCalculator
{
    class Calculator
    {
        static void Main(string[] args) {
            
            Console.WriteLine("Calculator");
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
            Console.Clear();
            
            Calculator c = new Calculator();
            c.Menu();

        }

        void Menu() {  
            int userChoice = 0;
            while (userChoice < 5) {
                Console.WriteLine("Calculator");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please Enter Your Choice: ");
                
                //userChoice = Console.Read();
                userChoice = Convert.ToInt32(Console.ReadLine());

                switch(userChoice) {
                    case 1:
                        Console.WriteLine("Before");
                        Addition();
                        Console.WriteLine("After");
                        break;
                    case 2:
                        Subtract();
                        break;
                    case 3:
                        Multiply();
                        break;
                    case 4:
                        Divide();
                        break;
                    default:
                        Console.WriteLine("Exit");
                        break;
                }
            }
        }

        public static void Addition() {
            Console.Clear();
            int a, sum = 0;
            int[] parameters = new int[10];
            Console.WriteLine("Enter The Number Of Parameters");

            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);

            for(int i = 0; i < a; i++) {
                parameters[i] = Console.Read();
            }
            for(int i = 0; i < parameters.Length; i++) {
                sum += parameters[i];
            }
            Console.WriteLine("Sum = {0}", sum);
        }

        void Subtract() {

        }
        void Multiply() {

        }
        void Divide() {

        }

    }
}
