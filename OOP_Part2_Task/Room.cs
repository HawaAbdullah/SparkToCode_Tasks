namespace OOP_Part2_Task;

public class Room
{
    public int RoomNumber { get; set; }
    public string RoomType { get; set; }
    public double pricePerNight { get; set; }
    public bool isAvailable { get; set; }

    public Room(int  roomNumber, string roomType, double pricePerNight)
    {
        RoomNumber = roomNumber;
        RoomType = roomType;
        this.pricePerNight = pricePerNight;
        
    }
    
    

    public void displayRoom(bool room)
    {
        Console.WriteLine("Room Number: " + RoomNumber+ "Room Type"+ RoomType + "Price: " + pricePerNight);
        
    }
}