using System.Reflection;

public abstract class Transaction
{
    //properties

    public string Name { get; set; }

    public string Description { get; set; }

    public double Amount { get; set; }

    public DateTime TimeStamp { get; set; }




    //constructors
    public Transaction(string name, string description, double amount, DateTime timeStamp)
    {
        Name = name;
        Description = description;
        Amount = amount;
        TimeStamp = timeStamp;

    }

    // methods 
}