using System;

class Program
{
    static void Main(string[] args)
    {

        // call the function to display the welcome message
        DisplayWelcome();

        // call the function to prompt the user for their name
        string nameUser = PromptUserName();

        // call the function to prompt the user for their favorite number
        int favnum = PromptUserNumber();

        // Call the funtion to calculate the square of the user's favorite number
        int squarefavnum = SquareNumber(favnum);

        // Call the function to display the message at the end

        DisplayResult(nameUser, squarefavnum);

    }


    // function for displaying a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //function for getting the user name

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string flname = Console.ReadLine();

        return flname;
    }

    // function for getting the user's number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // function to square the number
    static int SquareNumber(int numInput)
    {
        int squarednumber = numInput * numInput;

        return squarednumber;
    }

    // write a function to display the result of the name and the square of the favorite number
    static void DisplayResult(string flname, int squarenum)
    {
        Console.WriteLine($"{flname}, the square of your favorite number is {squarenum}");
    }

}