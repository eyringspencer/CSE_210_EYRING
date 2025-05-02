using System;

class Program
{
    static void Main(string[] args)
    {
        // prompt the user to enter a list of numbers and type 0 when finished
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // loop through code that will allow the user to enter numbers until they enter 0

        // declare and initialize a variable for the entered number
        int numInput = 1;

        // make a list to store numbers in
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter a number: ");
            numInput = int.Parse(Console.ReadLine());

            if (numInput != 0)
            {
                // add the user input to the list
            numbers.Add(numInput);

            }

            

        }while(numInput != 0);



        // calculate the sum of the numbers in the list
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");


        // calculate and display the average of the list
        double numAverage = numbers.Average();
        Console.WriteLine($"The average is: {numAverage}");

        // find the highest number
        int largest = numbers.Max();
        Console.WriteLine($"The largest Number is: {largest}");

        


    }
}