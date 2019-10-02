using System;
using System.Collections.Generic;
using System.Text;

namespace DogApplication {
    internal class Dog {
        /*
        Access Modifiers
        Public - Everyone can see.
        Internal - Everyone in the same assebmly can see.
        Protected - Everyone who is a subclass of Dog can see (Even if it is in another project)
        Private - Only this class can see
        Protected Internal
        Private Protected 

        For Class Members, private is default.
        For Classes, Internal is detfault - Only Public and internal are even possible
        */

        //Better than public fields, we can use Getter and Setter (Like Java)
        //But Even better is to use Properties in C#

        //Constructor
        public Dog(string name, int age) {
            //Within a class, "this" is a way to refer to the current instance of that class
            if(name == null) {
                throw new ArgumentNullException("name");
            }
            this.name = name;
            if(age < 0) {
                throw new ArgumentOutOfRangeException();
                //An Exception is how we represent and handle errors during runtime
            }
            this.age = age;
        }
        
        //Fields
        private string name;
        private int age;

        public string GetName() {
            return name;
        }
        public void SetName(string name) {
            this.name = name;
        }

        public int Age {
            get {
                return age; //Backing Field
            }
            set {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                age = value;
            }
        }
    }
}
