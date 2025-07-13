

using System.Diagnostics.Contracts;

public class BudgetManager
{
    //properties

    public List<Budget> Budgets { get; set; } = [];

    //constructor
    public BudgetManager()
    {
    }

    //methods

    public string AddBudget(Budget budget)
    {
        if (budget != null)
        {
            Budgets.Add(budget);
            return "Budget Added Successfully! ";
        }

        else
        {
            return "No Budget to Add. Try Again.";
        }
    }
    
}