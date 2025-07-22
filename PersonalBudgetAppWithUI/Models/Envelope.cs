using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetAppWithUI.Models;

public abstract class Envelope
{
    // properties

    public Guid Id { get; private set; } = Guid.NewGuid();

    public string Name { get; set; } = string.Empty;

    public decimal AmountAllocated { get; set; } = 0.0m;

    public List<Transaction> Transactions { get; private set; } = new();
    //CONSTRUCTOR
    public Envelope(string name, decimal amountAllocated)
    {
        Name = name;
        AmountAllocated = amountAllocated;
    }

}