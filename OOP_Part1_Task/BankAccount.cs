namespace OOP_Part1_Task;
public class BankAccount
{
    public int AccountNumber { get; set; }
    public string HolderName { get; set; }
    public double Balance { get; set; }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }

        return;
    }

    public double CheckBalance()
    {
        return Balance;
    }

    private void PrintInformation()
    {
        Console.WriteLine("Account number: " + AccountNumber);
        Console.WriteLine("Holder name: " + HolderName);
    }

    private void SendEmail()
    {

    }

}

