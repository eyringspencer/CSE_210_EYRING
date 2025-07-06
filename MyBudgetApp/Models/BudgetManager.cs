
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class BudgetManager
{
    //properites
    public ObservableCollection<Budget> Budgets { get; private set; }


    public Budget? CurrentBudget { get; set; }



    public Dictionary<string, decimal> PendingRolloverFunds { get; private set; }


    //constructor
    public BudgetManager()
    {
        Budgets = new ObservableCollection<Budget>();
        PendingRolloverFunds = new Dictionary<string, decimal>();

    }

    //methods

    public void AddBudget(Budget budget)
    {
        Budgets.Add(budget);
        CurrentBudget = budget;
    }

    

}