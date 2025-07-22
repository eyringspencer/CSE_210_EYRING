using Avalonia.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetAppWithUI.Models;

public class AdultEnvelope : Envelope
{
    //PROPERTIES
    public decimal GoalAmount { get; set; } = 0.0m;

    public decimal CurrentAccountBalance { get; set; } = 0.0m;

    public Account? ConnectedAccount { get; set; } = null;

    public decimal AmountContributed => Transactions.Sum(t => t.Amount);
    //CONSTRUCTOR
    public AdultEnvelope(string name, decimal amountAllocated, decimal goalAmount, decimal currentAccountBalance) 
        : base(name, amountAllocated)
    {
        GoalAmount = goalAmount;
        CurrentAccountBalance = currentAccountBalance;
    }

    //METHODS


}
