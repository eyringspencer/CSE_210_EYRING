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
                    Console.Clear();
                    BreathingActivity();
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


    static void BreathingActivity()
    {
        // create the breathing object
        Breathing breathing = new Breathing(0);

        // FIRST SCREEN
        Console.WriteLine(breathing.GetWelcomeText());
        Console.WriteLine();
        Console.WriteLine(breathing.GetDescriptionText());
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? >");
        int durationInput = int.Parse(Console.ReadLine());
        breathing.SetDuration(durationInput);

        // SECOND SCREEN
        Console.Clear();
        Console.WriteLine("Prepare to begin...");

        // waiting animation for 5 seconds

        // run the breathing animation for [x] seconds (figure out the timing later after thinking about it.)



    }


    static void RunBreathing(Breathing breathing)
    {
        Console.WriteLine();
        Console.Write(breathing.GetBreatheIn());

    }


    // function for a single line countdown animation
    static void CountDownAnimation(int seconds)
    {

        for (int i = seconds; i > 0; i--)
        {
            // print the current seconds to the console
            string countString = i.ToString();
            Console.Write(countString);
            Thread.Sleep(1000);

            //clear the console
            Console.Write(new string('\b', countString.Length));
            Console.Write(new string(' ', countString.Length));
            Console.Write(new string('\b', countString.Length));
        }










        // if (seconds > 10)
        // {
        //     for (int i = seconds; i > 0; i--)
        //     {
        //         Console.Write(i);
        //         Thread.Sleep(1000);
        //         Console.Write("\b \b");
        //     }
        // }

        // else
        // {
        //     for (int i = seconds; i > 0; i--)
        //     {
        //         Console.Write(i);
        //         Thread.Sleep(1000);
        //         Console.Write("\b\b \b\b");
        //     } 
        // }

    }
    
}