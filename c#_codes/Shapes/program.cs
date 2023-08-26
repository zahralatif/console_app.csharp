using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 6);
            Square square = new Square(3);
            Circle circle = new Circle(3);

            Console.WriteLine($"Area of Rectangle : {rectangle.GetArea()}");
            Console.WriteLine($"Perimeter of Rectangle : {rectangle.GetPerimeter()}");

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine($"Area of Square : {square.GetArea()}");
            Console.WriteLine($"Perimeter of Square : {square.GetPerimeter()}");

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine($"Area of Circle : {circle.GetArea()}");
            Console.WriteLine($"Perimeter of Circle : {circle.GetPerimeter()}");

            Console.WriteLine("----------------------------------------------------");

            Console.ReadKey();
        }
    }

}