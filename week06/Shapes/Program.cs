using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square(5, "Red");
        Rectangle rectangle = new Rectangle(4, 6, "Blue");
        Circle circle = new Circle(3, "Green");

        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}
