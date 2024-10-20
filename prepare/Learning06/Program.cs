using System;
using learning06;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square1 = new Square("Red", 4.50);
        shapes.Add(square1);
        Square square2 = new Square("Yellow", 12.32);
        shapes.Add(square2);
        Rectangle rect1 = new Rectangle("Green", 4.50, 5.50);
        shapes.Add(rect1);
        Rectangle rect2 = new Rectangle("Purple", 12.32, 6.54);
        shapes.Add(rect2);
        Circle circle1 = new Circle("Pink", 4.50);
        shapes.Add(circle1);
        Circle circle2 = new Circle("Blue", 12.32);
        shapes.Add(circle2);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} {shape.GetName()}'s area is {shape.GetArea()}");
        }
    }
}