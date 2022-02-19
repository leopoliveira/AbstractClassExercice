using System;
using AbstractMethods.Entities.Enums;

namespace AbstractMethods.Entities
{
    internal class Square : Shapes
    {
        public double Side { get; set; }

        public Square()
        {

        }

        public Square(Colors color, double side) : base(color)
        {
            Side = side;
        }

        public override double Area()
        {
            return Math.Pow(Side, 2);
        }

        public override string ToString()
        {
            return "Square: ";
        }
    }
}
