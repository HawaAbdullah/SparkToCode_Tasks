namespace OOP_Part1_Task;


public class Product
{
    public string ProductName { get; set; }

    public double Price { get; set; }

    public int StockQuantity { get; set; }

    public void Sell(int quantity)
    {
        if (quantity <= StockQuantity)
        {
            StockQuantity -= quantity;
            Console.WriteLine("Product sold successfully.");
        }
        else
        {
            Console.WriteLine("Not enough stock.");
        }

        LogTransaction();
    }

    public void Restock(int quantity)
    {
        StockQuantity += quantity;

        Console.WriteLine("Product restocked successfully.");

        LogTransaction();
    }



    public double GetInventoryValue()
    {
        PrintDetails();

        return Price * StockQuantity;
    }



    private void PrintDetails()
    {
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Stock Quantity: " + StockQuantity);
    }

    private void LogTransaction()
    {
        Console.WriteLine("Transaction has been logged.");
    }
}



