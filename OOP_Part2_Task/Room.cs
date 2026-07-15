namespace OOP_Part2_Task;

public class Room
{
    public int RoomNumber { get; set; }
    public string RoomType { get; set; }
    public int pricePerNight { get; set; }
    public bool isAvailable;
    
    

    public void displayRoom(bool room)
    {
        Console.WriteLine("Room Number: " + RoomNumber+ "Room Type"+ RoomType + "Price: " + pricePerNight);
        
    }
}