using System;
using System.ComponentModel.Design;
using System.Configuration.Assemblies;
using System.Diagnostics;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {

        GoalTracker tracker = new GoalTracker("blank", 0);
        
        bool quitEntered = false;

        List<Goal> goals = new List<Goal>();

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
                    Console.Clear();
                    DisplayCreateGoalMenu();
                    Console.Write("Enter the number of the type of goal that you would like to create. > ");
                    int goalTypeSelection = int.Parse(Console.ReadLine());

                    switch (goalTypeSelection)
                    {
                        case 1:
                            Console.Clear();
                            goals.Add(CreateSimpleGoal());
                            break;
                        case 2:
                            Console.Clear();
                            goals.Add(CreateEternalGoal());
                            break;
                        case 3:
                            Console.Clear();
                            goals.Add(CreateChecklistGoal());
                            break;
                    }

                    Console.WriteLine("Goal Successfully Created.");
                    Console.Write("Press ENTER to return to main menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Your goals are: ");
                    ListGoals();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Press ENTER to return to main menu");
                    Console.ReadLine();
                    Console.Clear();

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

    static void DisplayCreateGoalMenu()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

    }



    static SimpleGoal CreateSimpleGoal()
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

        // create and return a new simple goal object
        return new SimpleGoal(name, description, points);


    }


    static EternalGoal CreateEternalGoal()
    {
        Console.Write("What is the name of your goal? >");
        string name = Console.ReadLine();

        Console.Write("Give a short description of the goal. >");
        string description = Console.ReadLine();

        Console.WriteLine("Eternal goals are never truly complete. Points will be awarded after each recorded event of this goal.");
        Console.Write("How many points is completing an event of this goal worth?> ");
        int points = int.Parse(Console.ReadLine());

        return new EternalGoal(name, description, points);



    }

    static ChecklistGoal CreateChecklistGoal()
    {
        Console.Write("What is the name of your goal? >");
        string name = Console.ReadLine();

        Console.Write("Give a short description of the goal. >");
        string description = Console.ReadLine();

        Console.Write("How many points is completing a single event of this goal worth? >");
        int points = int.Parse(Console.ReadLine());

        Console.Write("A bonus can be earned upon completion of enough events of this goal. How many points bonus points should be awarded for completing the whole goal? > ");
        int bonusPoints = int.Parse(Console.ReadLine());

        Console.Write("How many times should an event of this goal be completed to earn the points bonus? > ");
        int completeCount = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, description, points, completeCount, bonusPoints);

    }


    static void ListGoals()
    {
        

    }

}