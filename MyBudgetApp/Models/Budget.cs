
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Numerics;
using System.Collections.ObjectModel;

///<summary>
/// This is the budget class. A new object of the budget class will be created each time the user creates a new budget period.
/// </summary>
public class Budget
{
    //properties
    public Guid Id { get; private set; }

    public string Name { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal Income { get; set; }

    public ObservableCollection<Transaction> Transactions { get; private set; }

    public ObservableCollection<Envelope> Envelopes { get; private set; }

    public string Notes { get; set; }

    public decimal TotalAllocated =>
        Envelopes
            .Sum(x => x.AllocatedAmount);

    public decimal UnallocatedFunds =>
        Income - TotalAllocated;

    public bool CanCreateBudget =>
        UnallocatedFunds == 0;

    //construtor
    public Budget(string name, DateTime startDate, DateTime endDate, decimal income, string notes)
    {
        Id = Guid.NewGuid();
        Name = name;
        StartDate = startDate;
        EndDate = endDate;
        Income = income;
        Notes = notes;
        Transactions = new ObservableCollection<Transaction>();
        Envelopes = new ObservableCollection<Envelope>();
    }


    //methods

    public bool AddTransaction(Transaction transaction)
    {
        var targetEnvelope = Envelopes.FirstOrDefault(e => e.Name == transaction.EnvelopeName);

        if (targetEnvelope != null)
        {
            Transactions.Add(transaction);
            return targetEnvelope.AddTransaction(transaction);

        }
        return false;
    }

    public bool RemoveTransaction(Guid transactionId)
    {
        var transactionToRemove = Transactions.FirstOrDefault(t => t.Id == transactionId);

        if (transactionToRemove != null)
        {
            Transactions.Remove(transactionToRemove);

            Envelopes
                .FirstOrDefault(e => e.Name == transactionToRemove.EnvelopeName)?
                .RemoveTransaction(transactionToRemove.Id);

            return true;
        }

        return false;
    }



}