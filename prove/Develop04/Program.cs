using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {

        bool quitEntered = false;

        //loop through the program so long as quit doesn't equal true

        do
        {
            DisplayStartMenu();

            int selection = int.Parse(Console.ReadLine());

            // switch logic for processing the selection
            switch (selection)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    quitEntered = true;
                    break;
            }

        } while (!quitEntered);
      

    }
    




    static void DisplayStartMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine();
            Console.WriteLine("Please select from one of the following menu options.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Enter a number from the menu: ");
        }
}