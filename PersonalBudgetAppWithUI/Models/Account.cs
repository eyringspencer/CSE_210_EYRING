using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetAppWithUI.Models;

public abstract class Account
{
    //PROPERTIES

    public string Name { get; set; } = string.Empty; // The name of the account

    public string Institution { get; set; } = string.Empty;

    public string AccountType { get; set; } = string.Empty; // The type of account (e.g., checking, savings, credit card)

    public decimal Balance { get; set; } = 0.0m; 

    //Constructor

    public Account(string name, string institution, string accountType, decimal balance)
    {
        Name = name;
        Institution = institution;
        AccountType = accountType;
        Balance = balance;
    }

    //Methods

    public abstract void Deposit(decimal amount);

    public abstract void Withdraw(decimal amount);
}
