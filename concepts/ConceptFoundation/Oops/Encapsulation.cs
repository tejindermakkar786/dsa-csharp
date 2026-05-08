public class Encapsulation
{
    public decimal Balance { get; private set; }

    public Encapsulation()
    {
        Balance = 0;
    }

    public string Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            return "Amount must be greater than 0";
        }
        if (amount > 10000)
        {
            return "There is a hard limit of 10k";
        }
        Balance += amount;
        return $"Amount {amount} deposited";
    }

    public string Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            return "Amount must be greater than 0";
        }
        if (amount > Balance)
        {
            return "Insuffient amount";
        }
        Balance -= amount;

        return "Withdrawl happend successfully";
    }
}