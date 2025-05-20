public class Account
{
    private List<int> _transactions = new List<int>();
    private int _balance = int.MinValue;

    public void Deposit(int amount)
    {
        _transactions.Add(amount);
        _balance = int.MinValue;
    }

    public void SetBalance(int balance)
    {
        _balance = balance;
    }

    public int GetBalance()
    {
        if (_balance == int.MinValue)
        {
            int runnningBalance = 0;
            foreach (int amount in _transactions)
            {
                runnningBalance += amount;
            }
            _balance = runnningBalance;
        }
        return _balance;
    }
}