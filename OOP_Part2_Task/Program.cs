namespace OOP_Part2_Task;

class Program
{
    
    
    
    static void Main(string[] args)
    {
        List<Room> rooms = new List<Room>();
        List<Guest> guests = new List<Guest>();
        

        while (true)
        {
            DisplayMainMenu(); 
            bool mune = false; 
            Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM"); 
            Console.WriteLine("choose an option"); 
            int c= int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1: 
                    Console.WriteLine("Add New Room");
                    Console.WriteLine("Enter Room Number: "); 
                    int roomNum = int.Parse(Console.ReadLine());
                    
                    bool exist = rooms.Any(r => r.RoomNumber == roomNum);
                    if (exist)
                    {
                        Console.WriteLine("Room Number already exists");
                    }
                    else
                    {
                        Console.WriteLine("Enter Room Type (Single / Double / Suite)"); 
                        string roomType = Console.ReadLine();
                    
                        Console.Write("Enter Price Per Night: ");
                        int pricePerNight = int.Parse(Console.ReadLine());
                        Room newRoom = new Room();
                        
                        newRoom.RoomNumber = roomNum;
                        newRoom.RoomType = roomType;
                        newRoom.pricePerNight = pricePerNight;
                        rooms.Add(newRoom);
                        Console.WriteLine("Add new room ");
                        
                        
                    }
                    
                    
                    
                    break; 
                case 2: 
                    Console.WriteLine("Register New Guest");
                    Console.WriteLine("Enter guest name: ");
                    string guestName = Console.ReadLine();
                    string guestId = "G" + guests.Count +1;
                    
                    Console.WriteLine("Enter Check In Day: ");
                    string day = Console.ReadLine();
                    Console.WriteLine("Enter Number of night: ");
                    int night = int.Parse(Console.ReadLine());
                    if (night < 0)
                    {
                        Console.WriteLine("Error, number of nights must be positive number");
                        return;
                    }
                    Console.WriteLine("Guest register successfully");
                    Console.WriteLine("Guest Name: " + guestName);
                    Console.WriteLine("Guest Id: " + guestId);
                    Console.WriteLine("Guest Type: " + day);
                    Console.WriteLine("Night: " + night);
                    break; 
                case 3: 
                    Console.WriteLine("Book a Room for a Guest"); 
                    break; 
                case 4: 
                    Console.WriteLine("View All Rooms"); 
                    break; 
                case 5: 
                    Console.WriteLine("View All Guests"); 
                    break; 
                case 6: 
                    Console.WriteLine("Search & Filter Rooms"); 
                    break; 
                case 7: 
                    Console.WriteLine("Guest & Booking Statistics"); 
                    break; 
                case 8: 
                    Console.WriteLine("Update Room Price"); 
                    break; 
                case 9: 
                    Console.WriteLine("Guest Lookup by Name"); 
                    break; 
                case 10: 
                    Console.WriteLine("Room Type Breakdown Report"); 
                    break; 
                case 11: 
                    Console.WriteLine("Check Out a Guest"); 
                    break; 
                case 12: 
                    Console.WriteLine("Remove Unavailable Rooms"); 
                    break; 
                case 13: 
                    Console.WriteLine("Extend Guest Stay"); 
                    break; 
                case 14: 
                    Console.WriteLine("Highest Revenue Booking"); 
                    break; 
                case 15: 
                    Console.WriteLine("Guest Pagination Viewer"); 
                    break; 
                case 0: 
                    Console.WriteLine("Thank you for using our system"); 
                    break; 
                default: 
                    Console.WriteLine("Not a valid option"); 
                    break;
        }
        }
        
        static void DisplayMainMenu()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
            Console.WriteLine("================================================");
            Console.WriteLine("1. Add New Room");
            Console.WriteLine("2. Register New Guest");
            Console.WriteLine("3. Book a Room for a Guest");
            Console.WriteLine("4. View All Rooms");
            Console.WriteLine("5. View All Guests");
            Console.WriteLine("6. Search & Filter Rooms");
            Console.WriteLine("7. Guest & Booking Statistics");
            Console.WriteLine("8. Update Room Price");
            Console.WriteLine("9. Guest Lookup by Name");
            Console.WriteLine("10. Room Type Breakdown Report");
            Console.WriteLine("11. Check Out a Guest");
            Console.WriteLine("12. Remove Unavailable Rooms");
            Console.WriteLine("13. Extend Guest Stay");
            Console.WriteLine("14. Highest Revenue Booking");
            Console.WriteLine("15. Guest Pagination Viewer");
            Console.WriteLine("0. Exit");
            Console.WriteLine("================================================");
            Console.Write("Enter your choice: ");
        }
        
        
    }
}