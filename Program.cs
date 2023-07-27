using ConsoleAppAssignment17;
using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle { ShapeType = "Circle", Radius = 5 };
        Rectangle rectangle = new Rectangle { ShapeType = "Rectangle", Width = 4, Height = 6 };
        Triangle triangle = new Triangle { ShapeType = "Triangle", SideA = 3, SideB = 4, SideC = 5 };

        circle.PrintInfo();
        Console.WriteLine();

        rectangle.PrintInfo();
        Console.WriteLine();

        triangle.PrintInfo();
        Console.WriteLine();

        Console.ReadKey();
    }
}