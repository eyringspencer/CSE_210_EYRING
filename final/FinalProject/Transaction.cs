


using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

public class Transaction
{
    //properties

    public DateTime Date { get; set; }

    public decimal Amount { get; set; }

    public string Vendor { get; set; }

    public string Description { get; set; }

    public string Type { get; set; }

    public string EnvelopeName{ get; set; }





    //constructor
    public Transaction(DateTime date, decimal amount, string vendor, string description, string type, string envelopeName)
    {
        Date = date;
        Amount = amount;
        Vendor = vendor;
        Description = description;
        Type = type;
        EnvelopeName = envelopeName;

    }


    //method




}