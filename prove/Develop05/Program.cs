using System;
using System.ComponentModel.Design;
using System.Configuration.Assemblies;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        GoalTracker tracker = new GoalTracker(0);

        bool quitEntered = false;



        //Welcome Message
        Console.WriteLine();
        Console.WriteLine("Welcome to the Goal tracking Program");
        Console.WriteLine();
        do
        {
            //display the original menu
            DisplayMenu(tracker);
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
                            tracker.Goals.Add(CreateSimpleGoal());
                            break;
                        case 2:
                            Console.Clear();
                            tracker.Goals.Add(CreateEternalGoal());
                            break;
                        case 3:
                            Console.Clear();
                            tracker.Goals.Add(CreateChecklistGoal());
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
                    DisplayGoalList(tracker);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Press ENTER to return to main menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("What is the filename for the goal file (eg. goals.txt) > ");
                    string fileName = Console.ReadLine();
                    tracker.Save(fileName);
                    Console.Write("Saving... ");
                    SpinnerAnimation();
                    Console.WriteLine($"File successfully saved to {fileName}");
                    Console.WriteLine();
                    Console.Write("Press ENTER to return to main menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("What is the filename for the goal file (eg. goals.txt) > ");
                    string loadfileName = Console.ReadLine();
                    tracker.Load(loadfileName);
                    Console.Write("Loading... ");
                    SpinnerAnimation();
                    Console.WriteLine($"{loadfileName} has been successfully loaded.");
                    Console.WriteLine();
                    Console.Write("Press ENTER to return to main menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    RecordGoal(tracker);
                    Console.WriteLine();
                    Console.Write("Press ENTER to return to main menu");
                    Console.Clear();

                    break;
                case 6:
                    quitEntered = true;
                    break;


            }
        } while (!quitEntered);

    }

    static void DisplayMenu(GoalTracker tracker)
    {
        Console.WriteLine($"You have {tracker.Score} points");
        Console.WriteLine();
        Console.WriteLine();


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
        Console.Write("What is the name of your goal? > ");
        string name = Console.ReadLine();

        Console.Write("Give a short description of the goal. > ");
        string description = Console.ReadLine();

        Console.WriteLine("Eternal goals are never truly complete. Points will be awarded after each recorded event of this goal.");
        Console.Write("How many points is completing an event of this goal worth?> ");
        int points = int.Parse(Console.ReadLine());

        return new EternalGoal(name, description, points);



    }

    static ChecklistGoal CreateChecklistGoal()
    {
        Console.Write("What is the name of your goal? > ");
        string name = Console.ReadLine();

        Console.Write("Give a short description of the goal. > ");
        string description = Console.ReadLine();

        Console.Write("How many points is completing a single event of this goal worth? > ");
        int points = int.Parse(Console.ReadLine());

        Console.Write("A bonus can be earned upon completion of enough events of this goal. How many points bonus points should be awarded for completing the whole goal? > ");
        int bonusPoints = int.Parse(Console.ReadLine());

        Console.Write("How many times should an event of this goal be completed to earn the points bonus? > ");
        int completeCount = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, description, points, completeCount, bonusPoints);

    }


    static void DisplayGoalList(GoalTracker tracker)
    {
        //List<string> goalList = new List<string>();

        //goalList = tracker.ListGoals();

        int goalNum = 0;

        foreach (Goal i in tracker.Goals)
        {
            goalNum += 1;
            Console.WriteLine($"{goalNum}. {i.GetStatus()}");

        }


    }

    static void RecordGoal(GoalTracker tracker)
    {
        Console.WriteLine("The goals are: ");
        int goalNum = 0;

        foreach (Goal goal in tracker.Goals)
        {
            goalNum += 1;
            Console.WriteLine($"{goalNum}. {goal.Name}");
        }

        Console.Write("Select a choice from the menu. > ");
        Goal selectedGoal = tracker.Goals[int.Parse(Console.ReadLine()) - 1];

        //record the goal
        selectedGoal.RecordEvent(tracker);

        Console.WriteLine($"Congratulations! You have earned {selectedGoal.Points} for completing an instance of the goal titled \"{selectedGoal.Name}\"");

        Console.WriteLine();
        Console.WriteLine($"Your overall score is: {tracker.Score} points"); // this needs to be specific to checklist goals whenever the goal type is 3






    }
    

    static void SpinnerAnimation()
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
        DateTime endTime = startTime.AddSeconds(6);

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