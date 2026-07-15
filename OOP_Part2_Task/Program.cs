namespace OOP_Part2_Task;

class Program
{
    List<Room> rooms = new List<Room>();
    List<Guest> guests = new List<Guest>();
    static void Main(string[] args)
    {
        bool mune = false;
        Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
        switch (mune == true)
        {
            case 1:
                Console.WriteLine("Add New Room");
                break;
            case 2:
                Console.WriteLine("Register New Guest");
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