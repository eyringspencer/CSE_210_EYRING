

using System.ComponentModel;
using System.Reflection;

public abstract class Account
{
    // properties
    public string Name { get; set; }

    protected double Balance { get; set; }

    private string _accountType;


    // constructors

    public Account(string name, double balance, string accountType)
    {
        Name = name;
        Balance = balance;
        _accountType = accountType;
    }


    //methods

    // public abstract void Deposit(double ammount);

    // public abstract void Withdrawl();
}