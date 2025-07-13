

using System.Transactions;

public class Envelope
{
    //properties
    public int EnvelopeNum { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public List<Transaction> Transactions { get; set; } = [];

    public decimal TotalAllocated { get; set; } = 0;

    public decimal AmountSpent =>
        Transactions
            .Sum(t => t.Amount);

    public decimal AmountRemaining =>
        TotalAllocated - AmountSpent;

    public bool Overdrawn =>
        AmountRemaining <= 0;


    //constructor
    public Envelope(int envelopeNum, string name, string description)
    {
        EnvelopeNum = envelopeNum;
        Name = name;
        Description = description;
    }

    //methods
    public void AddTransation(Transaction transaction)
    {
        Transactions.Add(transaction);
    }

    public void RemoveTransaction(Transaction transaction)
    {
        Transactions.Remove(transaction);
    }

    public void Allocate(int amount)
    {
        TotalAllocated = amount;
    }

}