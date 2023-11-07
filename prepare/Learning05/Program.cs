using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(3, "Blue");
        Rectangle rectangle = new Rectangle(2, 4, "Orange");
        Circle circle = new Circle(4, "Green");
        List<Shape> shapes = new List<Shape>
        {
            rectangle,
            square, 
            circle
        };
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"This {color} shape has an area of {area}");
        }
    }
}