using System;
using System.ComponentModel.Design;
using System.Configuration.Assemblies;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        bool quitEntered = false;

        //Welcome Message
        Console.WriteLine();
        Console.WriteLine("Welcome to the Goal tracking Program");
        Console.WriteLine();
        do
        {
            //display the original menu
            DisplayMenu();
            Console.Write("Select a choice from the menu > ");
            int menuSelection = int.Parse(Console.ReadLine());

            switch (menuSelection)
            {
                case 1:
                    CreateGoalMenu();
                    Console.Write("Enter the number of the type of goal that you would like to create. > ");
                    int goalTypeSelection = int.Parse(Console.ReadLine());

                    switch (goalTypeSelection)
                    {
                        case 1:
                            CreateSimpleGoal();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                    }

                    break;

                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    quitEntered = true;
                    break;


            }
        } while (!quitEntered);

    }

    static void DisplayMenu()
    {
        // WRITE SOMETHING HERE TO DISPLAY THE NUMBER OF POINTS THE USER HAS EVERY TIME THE MENU IS DISPLAYED. YOU COULD ADD FUNCTIONALITY WITH A BASE LEVEL CLASS, AND THEN HAVE DIFFERENT CLASSES FOR DIFFERENT LEVELS, LIKE BEGINNER, MASTER, AND MONK


        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");



    }

    static void CreateGoalMenu()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

    }



    static void CreateSimpleGoal()
    {
        // prompt for the name of the goal
        Console.Write("What is the name of your goal? > ");
        string name = Console.ReadLine();

        //prompt for the description of the goal
        Console.Write("Give a short description of the goal. >  ");
        string description = Console.ReadLine();

        //prompt for the number of points associated with the goal
        Console.Write("What is the amount of points associated with completion of this goal? > ");
        int points = int.Parse(Console.ReadLine());

        // create a new simple goal object
        SimpleGoal simpGoal = new SimpleGoal(name, description);

        // need to add this goal to a list of goals at some point

    }
}