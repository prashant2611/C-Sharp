using Interface.Shape.Libraries;
using System;

namespace Interface
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var square = new Square(4);
            Console.WriteLine($"Area of Square: {square.Area()}");

            var circle = new Circle(4);
            Console.WriteLine($"Area of Circle: {circle.Area()}");

            var rectangle = new Rectangle(4,5);
            Console.WriteLine($"Area of Rectangle: {rectangle.Area()}");
        }
    }
}
