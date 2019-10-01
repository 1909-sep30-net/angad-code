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

        void Menu(){  
            int userChoice = 0;
            do {
                Console.WriteLine("Calculator");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please Enter Your Choice: ");
                
                userChoice = Console.Read();

                switch(userChoice) {
                    case 1:
                        Addition();
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
                }
            } while (userChoice <= 5);
        }

        public static void Addition() {
            Console.Clear();
            int paramNo, sum = 0;
            int[] parameters = new int[10];
            Console.WriteLine("Enter The Number Of Parameters");
            paramNo = Console.Read();
            for(int i = 0; i < paramNo; i++) {
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
