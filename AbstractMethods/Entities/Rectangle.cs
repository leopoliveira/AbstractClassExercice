using AbstractMethods.Entities.Enums;

namespace AbstractMethods.Entities
{
    internal class Rectangle : Shapes
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(Colors color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle: ";
        }
    }
}
