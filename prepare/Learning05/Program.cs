using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;



class Program
{
    static void Main(string[] args)
    {
        // Step 5: Test Square
        Square square1 = new Square("blue", 4);

        Console.WriteLine($"{square1.Color} - {square1.GetArea()}");

        // Step 6: test rectangle and circle
        Rectangle rectangle1 = new Rectangle("Purple", 4, 5);
        Circle circle1 = new Circle("Yellow", 4);
        Console.WriteLine($"{rectangle1.Color} - {rectangle1.GetArea()}");
        Console.WriteLine($"{circle1.Color} - {circle1.GetArea()}");


        // Step 7: Build a List

        List<Shape> shapesList = new List<Shape>();
        shapesList.Add(new Square("blue", 4));
        shapesList.Add(new Rectangle("Purple", 4, 5));
        shapesList.Add(new Circle("Yellow", 4));

        foreach (Shape shape in shapesList)
        {
            Console.Write(shape.Color);
            Console.WriteLine(shape.GetArea());
        }

    }
}






public abstract class Shape
{


    // Constructor
    public Shape(string color)
    {
        Color = color;
    }


    //property for color
    public string Color { get; set; }

    //abstract area method
    public abstract double GetArea();

}



public class Square : Shape
{
    public double Side { get; set; }

    // constructor
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
    //properties
    public double Length { get; set; }
    public double Width { get; set; }

    // constructor
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
    // properties 
    public double Radius { get; set; }


    // Constructors
    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }

    // Methods

    public override double GetArea()
    {
        return 3.14 * (Radius * Radius);
    }


}
