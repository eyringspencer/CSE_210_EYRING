

using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using Avalonia.Rendering.Composition;

///<summary>
/// This is the abstract parent class for all of the envelopes
/// </summary>
public abstract class Envelope
{
    //properties

    public string Name { get; set; }

    public decimal AllocatedAmount { get; set; }

    public ObservableCollection<Transaction> Transactions { get; private set; }

    public decimal AmountSpent =>
        Transactions
            .Where(t => t.Type == TransactionType.Expense)
            .Sum(t => t.Amount);


    public virtual decimal AmountRemaining =>
        AllocatedAmount - AmountSpent;

    public bool IsOverSpent =>
        AmountRemaining < 0;

    public bool HasFundsLeft =>
        AmountRemaining > 0;

    public bool IsBalanced =>
        AmountRemaining == 0;


    //constructor
    public Envelope(string name, decimal allocatedAmount)
    {
        Name = name;
        AllocatedAmount = allocatedAmount;
        Transactions = new ObservableCollection<Transaction>();
    }

    //methods

    public bool AddTransaction(Transaction transaction)
    {
        Transactions.Add(transaction);

        return true;
    }

    public bool RemoveTransaction(Guid transactionId)
    {
        var transactionToRemove = Transactions.FirstOrDefault(t => t.Id == transactionId);

        if (transactionToRemove != null)
        {
            Transactions.Remove(transactionToRemove);
            return true;

        }

        return false;
    }



    public abstract decimal HandlePeriodClose();




}