using System;
using System.Security.Cryptography.X509Certificates;


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
    public Rectangle(double length, double width, string color) : base(color)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }
}














class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
    }
}