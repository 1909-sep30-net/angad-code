using System;

namespace DogApplication {
    class Program {
        static void Main(string[] args) {
            Dog dog = null;
            try {
                //In the try block, you put the code that you think may throw and exception that you can handle there
                dog = new Dog("Kaz", -4);
            }
            catch (ArgumentOutOfRangeException ex) {
                Console.WriteLine("Error, Recovering");
                dog = new Dog("Kaz", 4);
            }
            catch (ArgumentNullException ex) {
                Console.WriteLine("Error, Recovering");
                dog = new Dog("Kaz", 4);
            }
            dog.SetName("Kaz");
            dog.Age = 4;
        }
    }
}
