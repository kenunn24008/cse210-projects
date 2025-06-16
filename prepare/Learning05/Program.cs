using System;
using System.Drawing;

public abstract class Shape
{
    // private string _color;
    // a different way to do this ^^
    public Shape(string color)
    {
        Color = color;
    }

    public string Color { get; set; }

    public abstract double GetArea();
}

public class Square : Shape
{
    public double Side { get; set; }

    public Square(string color, double side) : base(color)
    {
        Side = side;
    }

    public override double GetArea()
    {
        return Side * Side;
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }

    public double Width { get; set; }

    public Rectangle(string color, double length, double width) : base(color)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * (Radius * Radius);
    } 
}
class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Blue", 5));
        shapes.Add(new Rectangle("Red", 5, 6));
        shapes.Add(new Circle("Green", 5.0));

        foreach (Shape shape in shapes)
        {
            DisplayInfo(shape);
        }
    }

    public static void DisplayInfo(Shape shape)
    {
        string color = shape.Color;
        double area = shape.GetArea();
        Console.WriteLine($"Color: {color}, Area: {area}");
    }
}