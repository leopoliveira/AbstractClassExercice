using System;
using System.Collections.Generic;
using System.Globalization;
using AbstractMethods.Entities;
using AbstractMethods.Entities.Enums;

namespace AbstractMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hello! Welcome to Shape Area Calculator...");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            List<Shapes> shapes = new List<Shapes>();

            Console.Write("First, enter with the number of shapes you'd like to calculate area: ");
            int numberOfShapes = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");

            for (int i = 1; i <= numberOfShapes; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Shape #{i}");
                Console.Write("Is it Circle, Rectangle or a Square (c/r/s) ? ");
                string shapeChoice = Console.ReadLine();

                while(true)
                {
                    if(shapeChoice == "c" || shapeChoice == "r" || shapeChoice == "s")
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("Ops... Wrong choice! Try again.");
                        Console.Write("Is it Circle, Rectangle or a Square (c/r/s) ? ");
                        shapeChoice = Console.ReadLine();
                    }
                }


                Console.Write("What's the color of it shape?\n\t1. Black;\n\t2. Blue;\n\t3. Red;\n\t4. Green;\nEnter corresponding number: ");
                Colors color = (Colors)int.Parse(Console.ReadLine());

                if(shapeChoice == "c")
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("You choose Circle!");
                    Console.Write("Enter circle's Radius (only numbers): ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(color, radius));
                } else if(shapeChoice == "r")
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("You choose Rectangle!");
                    Console.Write("Enter rectangle's Width (only numbers): ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Enter rectangle's Height (only numbers): ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(color, width, height));
                } else if(shapeChoice == "s")
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("You choose Square!");
                    Console.Write("Enter square's Side (only numbers): ");
                    double side = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Square(color, side));
                } else
                {
                    Console.WriteLine("Whooops! Something went wrong...");
                }
            }

            Console.WriteLine("--------------------------------------------\n");
            Console.WriteLine("Resume!");
            Console.WriteLine("Shapes Areas: ");

            foreach(Shapes shape in shapes) 
            {
                Console.WriteLine($"\t{shape}\n\tColor: {shape.Color}\n\tArea: {shape.Area().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("--------------------------------------------");
            }
            Console.WriteLine("\n");
            Console.WriteLine("BYE! BYE! Thanks for using...\nAtt.: Leonardo!\n\n");
        }
    }
}
