using System;
using AbstractMethods.Entities.Enums;

namespace AbstractMethods.Entities
{
    internal class Circle : Shapes
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(Colors color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return "Circle: ";
        }
    }
}
