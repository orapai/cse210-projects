using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();
        Square square = new Square("green", 2.5);
        list.Add(square);
        Rectangle rectangle = new Rectangle("red", 4.75, 3);
        list.Add(rectangle);
        Circle circle = new Circle("blue", 5.25);
        list.Add(circle);

        foreach (Shape shape in list)
        {
            Console.WriteLine($"Shape {shape.GetColor()} has an area of {shape.GetArea()}.");
        }   
    }
}