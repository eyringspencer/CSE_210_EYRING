using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Budget App");
        DisplayMainMenu();
        int menuSelection = int.Parse(Console.ReadLine());

        switch (menuSelection)
        {
            case 1:
                break;

            case 2:
                break;

            case 3:
                break;

        }



    }


    static void DisplayMainMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Please select from the following menu options");
        Console.WriteLine("  1. Accounts");
        Console.WriteLine("  2. Deposit Paycheck");
        Console.WriteLine("  3. Spending Categories");
        Console.Write("Enter the number of the menu option you'd like to select. > ")
    }
}