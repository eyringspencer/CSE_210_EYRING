

using System.Transactions;

public class HomeMenu : UI
{
    // properties

    public DateTime currentDate => DateTime.Now;

    //constructor

    public HomeMenu()
    {
        Text.Add("");
        Text.Add("Please select from the following menu options:");
        Text.Add("  1. List Budgets");
        Text.Add("  2. Create New Budget");
        Text.Add("  3. Quit Application");
        Text.Add("");

    }

    //methods

    public override void PromptInput()
    {
        Console.Write("Enter your selection > ");
    }

    public override string HandleInput()
    {
        return Console.ReadLine();
    }


}