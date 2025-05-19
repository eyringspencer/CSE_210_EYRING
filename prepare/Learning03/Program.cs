using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fractions Program");
        // use the default constructor
        Fraction f1 = new();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // use the second constructor
        Fraction f2 = new(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());


        // use the third constructor
        Fraction f3 = new(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());


        // test the numerator and denomenator getters and setters
        f1.SetTop(2);
        f1.SetBottom(2);
        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f1.GetBottom());

    }
}