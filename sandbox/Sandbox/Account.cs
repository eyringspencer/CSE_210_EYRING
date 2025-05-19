

// This class is a good example of encapsulation. The transaction details are only accessible from this class.
public class Account
{
    private List<int> _transactions = new List<int>(); // if we change this to a list...

    public void Deposit(int amount)
    {
        _transactions.Add(amount);
    }

    public int GetBalance()
    {
        int runningBalance = 0;

        foreach (int amount in _transactions)
        {
            runningBalance += amount;
        }

        return runningBalance;
    }
}