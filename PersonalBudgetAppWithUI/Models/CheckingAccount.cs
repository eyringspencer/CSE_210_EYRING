using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetAppWithUI.Models
{
    public class CheckingAccount : Account
    {
        //PROPERTIES
        // all inherited


        //CONSTRUCTOR
        public CheckingAccount(string name, string institution, decimal balance) : base(name, institution, "Checking", balance)
        {

        }

        //METHODS

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
}
