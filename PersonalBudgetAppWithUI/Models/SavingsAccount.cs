using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetAppWithUI.Models;

public class SavingsAccount : Account
{

    //PROPERTIES

    public double InterestRate { get; set; } = 0;

    //CONSTRUCTOR
    public SavingsAccount(string name, string institution, decimal balance) 
        : base(name, institution, "Savings", balance)
    {
    }

    //METHODS 

    // change these up to be more account specific
    public override void Deposit(decimal amount)
    {
        decimal newBalance = Balance + amount;
        if (newBalance > 0)
        {
            Balance = newBalance;
        }
        else
        {
            throw new InvalidOperationException("Deposit amount must be positive.");
        }
    }

    public override void Withdraw(decimal amount)
    {
        decimal newBalance = Balance - amount;
        if (newBalance >= 0)
        {
            Balance = newBalance;
        }
        else
        {
            throw new InvalidOperationException("Insufficient funds for withdrawal.");
        }
    }


}
