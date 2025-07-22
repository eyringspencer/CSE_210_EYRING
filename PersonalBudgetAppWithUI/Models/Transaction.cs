using Avalonia.Automation.Provider;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//ADD NAME SPACE
namespace PersonalBudgetAppWithUI.Models;

public class Transaction
{
    //PROPERTIES
    public Guid Id { get; private set; } = Guid.NewGuid();

    public decimal Amount { get; set; }

    public DateTime Date { get; private set; }

    public string Vendor { get; private set; }

    public string Description { get; set; } = string.Empty;

    public string Envelope { get; private set; }

    //CONSTRUCTOR

    public Transaction(decimal amount, DateTime date, string vendor, string envelope)
    {
        Amount = amount;
        Date = date;
        Vendor = vendor;
        Envelope = envelope;

    }


    //METHODS



}
