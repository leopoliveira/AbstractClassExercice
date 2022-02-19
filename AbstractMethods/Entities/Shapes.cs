using AbstractMethods.Entities.Enums;

namespace AbstractMethods.Entities
{
    abstract class Shapes
    {
        public Colors Color { get; set; }

        public Shapes()
        {

        }

        public Shapes(Colors color)
        {
            Color = color;
        }

        abstract public double Area();
    }
}
