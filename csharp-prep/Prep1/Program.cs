using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        // Prompt for the first and last name
        Console.Write("Please enter your first name: ");
        string first_name = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        string last_name = Console.ReadLine();

        // Write the Name in the Console
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}