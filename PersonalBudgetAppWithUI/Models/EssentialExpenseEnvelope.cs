using PersonalBudgetAppWithUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetAppWithUI.Models;

public abstract class EssentialExpenseEnvelope : Envelope
{
    //PROPERTIES
    
    //the date on which this balance needs to be 0 
    public DateTime DueDate { get; set; }

    //the amount that is due by the due date. It doesnt change for rent, but would change for utilites.
    public decimal AmountDue { get; set; } = 0.0m;

    public virtual decimal RemainingBalance => AmountDue - Transactions.Sum(t => t.Amount);

    //CONSTRUCTOR
    public EssentialExpenseEnvelope(string name, decimal amountAllocated, DateTime dueDate, decimal amountDue) : base(name, amountAllocated)
    {
        DueDate = dueDate;
        AmountDue = amountDue;

    }

    //METHODS
}
