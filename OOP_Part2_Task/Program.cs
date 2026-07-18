using System.Globalization;

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
                    Console.WriteLine("Enter guest ID: ");
                    int guestID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Room Number: ");
                    int roomNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter room number: "+roomNumber);
                    Console.WriteLine(guestID);
                    Guest foundGuest = guests.FirstOrDefault(guestID => guestID.Equals(guestID));
                    Room foundRoom = rooms.FirstOrDefault(room => room.RoomNumber == roomNumber);
                    if (foundGuest == null)
                    {
                        Console.WriteLine("Can not found the guest");
                    }
                    else if (foundRoom == null)
                    {
                        Console.WriteLine("Can not found the room");
                    }
                    else if (foundRoom.isAvailable == false)
                    {
                        Console.WriteLine("Can not found the room, its already booked ");
                    }
                    else
                    {
                        foundGuest.roomNumber = foundRoom.roomNumber.ToString(); 
                        foundRoom.isAvailable = false;
                        double totalCost = foundGuest.calculateTotalCost(foundRoom.pricePerNight);
                        Console.WriteLine("The booking has been successfully confirmed.");
                        Console.WriteLine("The total cost is: " + totalCost);
                        Console.WriteLine("");
                    }
                    
                    break; 
                case 4: 
                    Console.WriteLine("View All Rooms");
                    if (rooms.Count > 0)
                    {
                        Console.WriteLine("No rooms has been added yet ");
                    }
                    else
                    {
                        Console.WriteLine("Room number available "+rooms.Count);
                        foreach (var room in rooms)
                        {
                            string status = room.isAvailable ? "Available" : "Unavailable";
                            Console.WriteLine("Room number: " + room.RoomNumber+"Room type: "+room.RoomType+ "Room price: "+room.pricePerNight+" Room status: "+status);
                        }
                        
                    }
                    
                    break; 
                case 5: 
                    Console.WriteLine("View All Guests");
                    if (guests.Count > 0)
                    {
                        Console.WriteLine("No guest has been regester yet ");
                    }
                    else
                    {
                        Console.WriteLine("Guest number available "+guests.Count);
                        foreach (var guest in guests )
                        {
                            Console.WriteLine("Guest id: "+guest.guestId +"Name: "+guest.guestName+" Room number: "+guest.roomNumber +" Total Night"+ guest.totalNights);
                        }
                    }
                    break; 
                case 6: 
                    Console.WriteLine("Search & Filter Rooms");
                    Console.WriteLine("1. Show all available rooms");
                    Console.WriteLine("2.  Filter by room type");
                    Console.WriteLine("3.  Filter by max price");
                    Console.WriteLine("4. Room price statistics");
                    Console.WriteLine("0. Back");
                    Console.WriteLine("Choose Option");
                    string option = Console.ReadLine();

                    if (option == "1")
                    {
                        var availableRooms = rooms.Where(room => room.isAvailable).OrderBy(room => room.pricePerNight).ToList();
                        Console.WriteLine("Available Rooms: "+ availableRooms.Count());
                        if (availableRooms.Any())
                        {
                            Console.WriteLine("No room found ");
                        }
                        else
                        {
                            foreach (var room in availableRooms)
                                Console.WriteLine("Room number : " + room.RoomNumber + "Room type: " + room.RoomType +"Room price: "+room.pricePerNight);
                        }
                    }
                    else if (option == "2")
                    {
                        Console.WriteLine("Enter the Room type (Single / Double / Suite):" );
                        string  roomType = Console.ReadLine();
                        var filterByType = rooms.Where(room => room.RoomType.Equals(roomType, StringComparison.OrdinalIgnoreCase));
                        Console.WriteLine("room type "+roomType+ filterByType.Count());
                        if (filterByType.Any())
                        {
                            Console.WriteLine("No rooms found for the selected criteria.");
                        }
                        else
                        {
                            foreach (var room in filterByType)
                            {
                                Console.WriteLine("Room number "+room.RoomNumber+ " Room price: "+room.pricePerNight+" staue: "+room.isAvailable);
                                
                                
                            }
                        }
                    }
                    else if (option == "3")
                    {
                        Console.WriteLine("Write the maximam price: ");
                        double maxprice = double.Parse(Console.ReadLine());
                        var budgetRooms= rooms.Where(room => room.isAvailable).OrderByDescending(room => room.pricePerNight).ToList();
                        if (!budgetRooms.Any())
                        {
                            Console.WriteLine("No rooms found for the selected criteria.");
                        }
                        else
                        {
                            foreach (var room in budgetRooms)
                                Console.WriteLine("Room number "+room.RoomNumber + " Room type "+room.RoomType +"Room price: "+room.pricePerNight);
                        }
                    }
                    else if (option == "4")
                    {
                        if (!rooms.Any())
                        {
                            Console.WriteLine("No rooms found for the selected criteria.");
                        }
                        else
                        {
                            int totalCount = rooms.Count();
                            int availableCount = rooms.Count(r => r.isAvailable); 
                            double avgPrice = rooms.Average(r => r.pricePerNight);
                            double minPrice = rooms.Min(r => r.pricePerNight);
                            double maxPrice = rooms.Max(r => r.pricePerNight);

                            
                            Console.WriteLine("Statistics report");
                            Console.WriteLine("Total number of rooms "+totalCount);
                            Console.WriteLine("Available Rooms: "+ availableCount);
                            Console.WriteLine("avrage price "+avgPrice);
                            Console.WriteLine("Available Rooms: " + availableCount);
                            Console.WriteLine("Min Price: " + minPrice);
                            Console.WriteLine("Max Price: " + maxPrice);
                            
                        }
                    }
                    else if (option == "0")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option");
                    }
                    
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