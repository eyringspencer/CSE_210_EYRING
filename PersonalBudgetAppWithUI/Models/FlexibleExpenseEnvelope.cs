using PersonalBudgetAppWithUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ADD NAME SPACE

public class FlexibleExpensesEnvelope : Envelope
{
    //PROPERTIES
    public decimal AmountSpent => Transactions.Sum(t => t.Amount);

    public decimal AmountRemaining => AmountAllocated - AmountSpent;


    //CONSTRUCTOR
    public FlexibleExpensesEnvelope(string name, decimal amountAllocated) : base(name, amountAllocated)
    {

    }   

    //METHODS
}
