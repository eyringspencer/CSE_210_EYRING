

using System;
using Avalonia.Automation.Provider;

///<summary>
/// a data class for each transaction
/// </summary>
public class Transaction
{
    //properties

    // a unique id for each of the transactions
    public Guid Id { get; private set; }

    // transaction amount
    public decimal Amount { get; set; }

    public DateTime Date { get; set; }

    public string Description { get; set; }

    public TransactionType Type { get; set; }

    public string EnvelopeName { get; set; }



    //constructor
    public Transaction(decimal amount, DateTime date, string description, TransactionType type, string envelopeName)
    {
        Id = Guid.NewGuid();
        Amount = amount;
        Date = date;
        Description = description;
        Type = type;
        EnvelopeName = envelopeName;
    }

    //methods
}