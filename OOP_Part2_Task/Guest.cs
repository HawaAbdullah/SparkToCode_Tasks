namespace OOP_Part2_Task;

public class Guest
{
    public string guestId { set; get; }
    public string guestName { set; get; }
    public int roomNumber { set; get; }
    public DateTime checkInDate { set; get; }
    public int totalNights { set; get; }

    public void displayGuest(string guest)
    {
        Console.WriteLine("Guest: " + guestId+ " Name: " + guestName + " Room Number: " + roomNumber+"Nights: "+totalNights);
    }

    
    public double calculateTotalCost(double totalPrice)
    {
        return totalNights * totalPrice;
    }
}