///<summary>
/// This is a child of the envelope class and will handle things like groceries in which months where less is spent, excess can be rolled over to the budget for the next month.
/// </summary>



public class RolloverExpenseEnvelope : Envelope
{
    //properties
    // all inherited

    //constructor
    public RolloverExpenseEnvelope(string name, decimal allocatedAmount) : base(name, allocatedAmount)
    {

    }

    // methods

    public override decimal HandlePeriodClose()
    {
        return AmountRemaining;
    }

}