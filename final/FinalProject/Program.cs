using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        /*
        //START MAIN SCREEN
        Console.Clear();
        UI homeScreen = new HomeMenu();
        homeScreen.Show(); // display the home menu
        homeScreen.PromptInput(); // prompt the user for input
        int selection = int.Parse(homeScreen.HandleInput());
        //END MAIN SCREEN
        */

        BudgetManager manager = new BudgetManager();

        bool quitEntered = false;

        do
        {
            Console.Clear();
            DisplayMainMenu();
            int menuSelection = int.Parse(Console.ReadLine());

            switch (menuSelection)
            {
                case 1:
                    Console.Clear();
                    DisplayBudgetsList(manager);
                    Console.Write("Please enter the number of the budget that you would like to view, or press ENTER to return to main menu. > ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Returning to Main Menu");
                        SpinnerAnimation();
                    }


                    else
                    {
                        int selectedBudgetNum = int.Parse(input);
                        Budget selectedBudget = manager.Budgets[selectedBudgetNum - 1];
                        Console.Clear();
                        DisplayBudgetDetails(selectedBudget);
                        Console.WriteLine();
                        Console.Write("Please enter the number of the envelope that you would like to see details for. If you would like to return to the main menu, simply press ENTER > ");
                        string selectedEnvelopeInput = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(selectedEnvelopeInput))
                        {
                            Console.WriteLine("Returning to Main Menu");
                            SpinnerAnimation();
                        }

                        else
                        {
                            int selectedEnvelopeNum = int.Parse(selectedEnvelopeInput);

                        }



                        // add something here that calls a display envelope details menu
                    }

                    break;

                case 2:
                    Console.Clear();
                    Budget newBudget = CreateBudget();
                    manager.AddBudget(newBudget);
                    Console.Write("Creating New Budget:");
                    SpinnerAnimation();
                    break;

                case 3:
                    quitEntered = true;
                    break;

            }


        } while (quitEntered == false);

        

    }


    static void DisplayMainMenu()
    {
        Console.WriteLine("Welcome to the Budget Application");
        Console.WriteLine();
        Console.WriteLine("Please select from the following menu options");
        Console.WriteLine("  1. View Budgets");
        Console.WriteLine("  2. Create New Budget");
        Console.WriteLine("  3. Quit Program");
        Console.Write("Please Enter Your Selection > ");
    }



    static void DisplayBudgetsList(BudgetManager budgetManager)
    {
        int budgetNo = 0;

        Console.WriteLine("Budgets: ");
        foreach (Budget budget in budgetManager.Budgets)
        {
            budgetNo++;
            Console.WriteLine($"{budgetNo}. {budget.Name} for period {budget.StartDate} - {budget.EndDate}");
        }

        Console.WriteLine(".\n.\n.");


    }



    static void DisplayBudgetDetails(Budget budget)
    {
        Console.WriteLine(budget.Name);
        Console.WriteLine($"{budget.StartDate} - {budget.EndDate}");

        //display a message that lets the user know that no funds have been allocated yet.
        if (budget.TotalAllocated == 0)
        {
            Console.WriteLine(".");
            Console.WriteLine("ATTENTION. FUNDS HAVE NOT BEEN ALLOCATED TO THIS BUDGET YET");
            Console.WriteLine(".");
        }

        foreach (Envelope envelope in budget.Envelopes)
        {
            Console.WriteLine();
            Console.WriteLine($"{envelope.EnvelopeNum}. {envelope.Name}");
            Console.WriteLine($"Allotment: {envelope.TotalAllocated}");
            Console.WriteLine($"Amount Spent: {envelope.AmountSpent}");
            Console.WriteLine($"Amount Remaining: {envelope.AmountRemaining}");

            if (budget.TotalAllocated == 0)
            {

            }

            else
            {
                if (!envelope.Overdrawn)
                {
                    Console.WriteLine($"Congratulations, you may spend an additional {envelope.AmountRemaining} before {budget.EndDate}");
                }
                else
                {
                    Console.WriteLine($"You have spent as much or more than the alloted amount for this expense category. Please wait for next month to spend here again.");

                }
            }

            Console.WriteLine(".");
        }


    }


    static void DisplayEnvelopeDetails(Envelope envelope)
    {
        Console.WriteLine($"{envelope.EnvelopeNum}. {envelope.Name}");
        Console.WriteLine($"Allotment: {envelope.TotalAllocated}");
        Console.WriteLine($"Amount Spent: {envelope.AmountSpent}");
        Console.WriteLine($"Amount Remaining: {envelope.AmountRemaining}");
    }

    static Budget CreateBudget()
    {
        Console.WriteLine("You will now create a new budget");
        Console.WriteLine(".\n.");

        // User names the budget name and store it for construction later
        Console.Write("What is the name for your budget? (EG. July, November, Summer) > ");
        string name = Console.ReadLine();

        // User provides start and end dates stored for construction later
        Console.Write("What is the start date for this budgeting period? > ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        Console.Write("What is the end date for this budgeting period? > ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        return new Budget(name, startDate, endDate);

    }
    
    
    static void SpinnerAnimation()
    {
        //list of strings for the spinner animation
        List<string> spinnerStrings =
        [
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
        ];

        Console.CursorVisible = false;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);

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