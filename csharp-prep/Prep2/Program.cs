using System;

class Program
{
    static void Main(string[] args)
    {
        // Program to determine the letter grade for a course


        // Prompt the user for their grade percentage
        Console.Write("Please enter your grade percentage rounded to the nearest whohle number and without a percent sign: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        // Determine the letter grade
        if (grade >= 90)
        {
            Console.WriteLine("Your Letter Grade is A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your Letter Grade is B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your Letter Grade is C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your Letter Grade is D");
        }
        else
        {
            Console.WriteLine("Your Letter Grade is F");
        }
    }
}