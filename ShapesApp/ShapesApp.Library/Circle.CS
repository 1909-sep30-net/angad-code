using System;

namespace ShapesApp.Library {

    public class Circle : IShape
    {
        public int Dimensions => 2;

        public int Sides => 0;

        public double Area => Math.PI * Radius * Radius;

        public double Radius { get; set; }

        public virtual double GetPerimeter() //Non Virtual Methods can not be overwritten
        {
            throw new NotImplementedException();
        }
    }

}