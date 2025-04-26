using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Program to determine the letter grade for a course


        // Prompt the user for their grade percentage
        Console.Write("Please enter your grade percentage rounded to the nearest whohle number and without a percent sign: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        // create an empty letter grade variable
        string letter_grade;

        // Determine the letter grade
        if (grade >= 90)
        {
            letter_grade = "A";
        }
        else if (grade >= 80)
        {
            letter_grade = "B";
        }
        else if (grade >= 70)
        {
            letter_grade = "C";
        }
        else if (grade >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
        }

        // Print the Letter Grade 
        // QUESTION FOR CLASS: Wouldn't this be a dangerous setup because there's a chance that all of the conditions fail? Wouldn't that make it so that the console write statement is empty? Or does the else take care of that?
        Console.WriteLine($"Your letter grade is: {letter_grade}");

        // DETERMINE IF THE GRADE IS A PASSING GRADE
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class.");

        }
        else
        {
            Console.WriteLine("You have failed the class. Better luck next time!");
        }


        // STRETCH CHALLENGES

        // calculate the residual after dividing the grade percentage
        int res = grade % 10;


        // declare the sign variable as a string an initialize it to be blank
        string sign = "";

        // Conditional logic for sign assignment
        if (grade >= 90)
        {
            if (res < 3)
            {
                sign = "-";
            }
        }

        else if (grade >= 60)
        {
            if (res >= 7)
            {
                sign = "+";
            }
            else if (res < 3)
            {
                sign = "-";
            }
        }

        // print the letter grade with the appropriate sign
        Console.WriteLine($"Your Specific Letter Grade is: {letter_grade}{sign}");


        

        
    }
}