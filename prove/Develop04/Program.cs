using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {

        bool quitEntered = false;

        //loop through the program so long as quit doesn't equal true

        do
        {
            Console.Clear();
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
                    Console.Clear();
                    ReflectingActivity();

                    break;

                case 3:
                    Console.Clear();
                    ListingActivity();
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
        Console.Write("Enter a number from the menu > ");
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
        Console.Write("How long, in seconds, would you like for your session? > ");
        int durationInput = int.Parse(Console.ReadLine());
        breathing.SetDuration(durationInput);

        // SECOND SCREEN
        Console.Clear();
        Console.WriteLine("Prepare to begin...");

        // waiting animation for 5 seconds
        CountDownAnimation(5);


        // run
        RunBreathing(breathing);

        // end message
        Console.WriteLine(breathing.GetEndMessage());
        Console.WriteLine();

        // activity report
        Console.WriteLine($"You have completed another {breathing.GetDuration()} seconds of the Breathing Activity");

        // end spiner
        SpinnerAnimation(8);



    }


    static void RunBreathing(Breathing breathing)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(breathing.GetDuration());
        DateTime currentTime;

        do
        {
            currentTime = DateTime.Now;
            Console.WriteLine();
            Console.Write(breathing.GetBreatheIn());
            CountDownAnimation(4);
            Console.WriteLine();
            Console.Write(breathing.GetBreatheout());
            CountDownAnimation(4);
            Console.WriteLine();
            Console.WriteLine();


        } while (currentTime < futureTime);
    }

    static void ReflectingActivity()
    {
        //create a new reflecting object
        Reflecting reflecting = new Reflecting(0);

        // FIRST SCREEN
        Console.WriteLine(reflecting.GetWelcomeText());
        Console.WriteLine();
        Console.WriteLine(reflecting.GetDescriptionText());
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? > ");
        int durationInput = int.Parse(Console.ReadLine());
        reflecting.SetDuration(durationInput);

        // SECOND SCREEN
        Console.Clear();
        Console.WriteLine("Prepare to begin...");
        CountDownAnimation(5);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($" --- {reflecting.GetPrompt()} --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Write("> ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountDownAnimation(5);

        // THIRD SCREEN
        RunReflecting(reflecting);

        Console.WriteLine(reflecting.GetEndMessage());
        Console.WriteLine();

        Console.WriteLine($"You have completed another {reflecting.GetDuration()} seconds of the Reflecting Activity");

        SpinnerAnimation(8);


        
    }

    static void RunReflecting(Reflecting reflecting)
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(reflecting.GetDuration());
        DateTime currentTime;

        List<int> followUpIndicies = new List<int>();

        do
        {
            currentTime = DateTime.Now;
            Random rand = new Random();
            int index;

            if (followUpIndicies.Count() >= reflecting.GetFollowUpCount())
            {
                followUpIndicies.Clear();
            }

            do
            {
                index = rand.Next(reflecting.GetFollowUpCount());
            } while (followUpIndicies.Contains(index));

            followUpIndicies.Add(index);

            Console.Write($"-> {reflecting.GetFollowUp(index)}");
            SpinnerAnimation(7);
            Console.WriteLine();





        } while (currentTime < futureTime);
    }


    static void ListingActivity()
    {
        Listing listing = new Listing(0);

        // FIRST SCREEN
        Console.WriteLine(listing.GetWelcomeText());
        Console.WriteLine();
        Console.WriteLine(listing.GetDescriptionText());
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? > ");
        int durationInput = int.Parse(Console.ReadLine());
        listing.SetDuration(durationInput);

        // SECOND SCREEN
        Console.Clear();
        Console.WriteLine("Prepare to begin...");
        CountDownAnimation(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {listing.GetPrompt()} --- ");
        Console.WriteLine();
        Console.Write("You may begin in...");
        CountDownAnimation(3);
        Console.WriteLine();

        //runlisting
        RunListing(listing);
        Console.WriteLine(listing.GetEndMessage());
        Console.WriteLine($"You have completed another {listing.GetDuration()} seconds of the Listing Activity");
        SpinnerAnimation(8);


        

    }

    static void RunListing(Listing listing)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(listing.GetDuration());
        DateTime currentTime;
        int count = 0;

        do
        {
            currentTime = DateTime.Now;
            Console.Write("> ");
            Console.ReadLine();
            count++;
        } while (currentTime < futureTime);

        
        Console.WriteLine($"You listed {count} items!");
        Console.WriteLine();
    }

    // function for a single line countdown animation
    static void CountDownAnimation(int seconds)
    {

        for (int i = seconds; i > 0; i--)
        {
            // hide the cursor
            Console.CursorVisible = false;

            // print the current seconds to the console
            string countString = i.ToString();
            Console.Write(countString);
            Thread.Sleep(1000);

            //clear the console
            Console.Write(new string('\b', countString.Length));
            Console.Write(new string(' ', countString.Length));
            Console.Write(new string('\b', countString.Length));

            Console.CursorVisible = true;
        }

    }


    static void SpinnerAnimation(int seconds)
    {
        //list of strings for the spinner animation
        List<string> spinnerStrings = new List<string>();
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");

        Console.CursorVisible = false;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");

            i++;
            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }


        Console.CursorVisible = true;


    }
    
}