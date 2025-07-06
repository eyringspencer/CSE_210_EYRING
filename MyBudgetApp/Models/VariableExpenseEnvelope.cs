

using System;

///<summary>
/// This is a child class of envelope. It will handle expense categories like utilities which don't necessarily roll over to the next month, but the number can change. At period close, the remaining balance will be pushed to the appropriate savings envelope.
/// </summary>
public class VariableExpenseEnvelope : Envelope
{
    //properties
    public DateTime DueDate { get; set; }


    //constructor
    public VariableExpenseEnvelope(string name, decimal allocatedAmount, DateTime dueDate) : base(name, allocatedAmount)
    {
        DueDate = dueDate;
    }

    //methods
    public override decimal HandlePeriodClose()
    {
        return AmountRemaining;
    }


}