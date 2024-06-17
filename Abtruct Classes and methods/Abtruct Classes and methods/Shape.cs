using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtruct_Classes_and_methods
{
    // Abstract class with an abstract method
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class that implements the abstract method
    class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class that implements the abstract method
    class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double GetArea()
        {
            return length * width;
        }
    }
}
