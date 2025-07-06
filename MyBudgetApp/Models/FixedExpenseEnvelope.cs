

using System;
using System.Text.Json.Serialization;

///<summary>
/// This is a child class of envelope for fixed expenses in which the amount does not change like rent. Remaining amounts will be returned to unallocated funds
/// </summary>
public class FixedExpenseEnvelope : Envelope
{
    //properties
    public DateTime DueDate { get; set; }

    public bool IsPaid =>
        IsBalanced == true;

    //constructor
    public FixedExpenseEnvelope(string name, decimal allocatedAmount, DateTime dueDate) : base(name, allocatedAmount)
    {
        DueDate = dueDate;
    }

    //methods

    public override decimal HandlePeriodClose()
    {
        return AmountRemaining;
    }

    
}