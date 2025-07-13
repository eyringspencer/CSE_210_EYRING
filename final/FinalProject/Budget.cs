

using System.Numerics;
using System.Reflection.Metadata.Ecma335;

public class Budget
{
    //properties
    public string Name { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public List<Transaction> Transactions { get; set; } = [];

    public List<Envelope> Envelopes { get; set; }

    public decimal TotalAllocated { get; set; } = 0;

    public decimal TotalSpent =>
        Envelopes
            .Sum(e => e.AmountSpent);

    public decimal TotalRemaining =>
        TotalAllocated - TotalSpent;

    // constructor
    public Budget(string name, DateTime startDate, DateTime endDate)
    {
        Name = name;
        StartDate = startDate;
        EndDate = endDate;
        Envelopes = new List<Envelope>
        {
            new Envelope(1, "Rent", "To be paid in full on the 20th of each month. (Includes parking fee)"),
            new Envelope(2, "Utilities", "To be paid in full on the 15th of each month. Amount varries from $50-$80"),
            new Envelope(3, "Groceries", "This includes anything that we buy from the store such as food and hygene products"),
            new Envelope(4, "Fun", "Should be allocated last. This amount can roll over to the next month."),
            new Envelope(5, "Eating Out", "Money used for eating at restaurants"),
            new Envelope(6, "Gas", "Rolls over to the next month. Gas goes toward pickup and subaru."),
            new Envelope(7, "To Be Saved", "Goal is to save 25 percent of our monthly income."),
            new Envelope(8, "Tithing", "Constitues 10% of each paycheck."),
            new Envelope(9, "Misc.", "Catchall for any transaction that doesn't fit into other envelopes")
        };
    }

    // methods

    public void Allocate(decimal amount)
    {
        TotalAllocated = amount;
    }
}