using System;

namespace ShapesApp.Library {

    public class ColorCircle : Circle {
        public string Color { get; set; }

        public override double GetPerimeter() { //To Override a method we must use a modifier "override". It's not allowed if the existing implementation is non-virtual
            Console.WriteLine("Calculating Perimeter");
            //return 2 * Math.PI * Radius;
            return base.GetPerimeter(); //Uses base class Implementation
        }

    }

}