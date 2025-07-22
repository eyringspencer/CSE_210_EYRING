using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PersonalBudgetAppWithUI.Models;

public class Budget
{
    //PROPERTIES
    public Guid IdNum { get; private set; } = Guid.NewGuid();

    public string Name { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal Income { get; set; } = 0.0m;

    public List<Transaction> Transactions { get; private set; } = new();

    public string Status { get; set; } = "Open";

    public List<Envelope> Envelopes { get; private set; } = new();

    public decimal TotalAllocated => Envelopes.Sum(e => e.AmountAllocated);

    public decimal UnallocatedFunds => Income - TotalAllocated;

    //CONSTRUCTOR
    public Budget(string name, DateTime startDate, DateTime endDate, decimal income)
    {
        Name = name;
        StartDate = startDate;
        EndDate = endDate;
        Income = income;
    }

    //METHODS

    // A method for closing the budget, forcing rollover funds out to the budget manager, 
}
