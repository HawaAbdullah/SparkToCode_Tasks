namespace OOP_Part1_Task;

class Program
{


    static BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "karim", Balance = 120 };
    static BankAccount account2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };

    static Student student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
    static Student student2 = new Student { Name = "Ahmed", Address = "Muscat", Grade = 70 };

    static Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };

    static Product product2 = new Product
        { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };



    static void ViewAccountDetails()
    {
        Console.WriteLine("Choose account 1 or 2: ");
        int i = int.Parse(Console.ReadLine());
        if (i == 1)
        {
            double result = account1.CheckBalance();
            Console.WriteLine("Your Balance is " + result);
        }
        else if (i == 2)
        {
            double result = account2.CheckBalance();
            Console.WriteLine("Your Balance is " + result);
        }
        else
        {
            Console.WriteLine("Enter valid account number");
        }
    }

    static void UpdateStudentAddress()
    {
        Student student = ChooseStudent();
        Console.WriteLine("Enter your new address: ");
        string newAddress = Console.ReadLine();
        student1.Address = newAddress;
        Console.WriteLine("Address updated successfully." + student.Address);


    }

    static void MakeDeposit()
    {
        ChooseBankAccount();

    }

    static void MakeWithdrawal()
    {
        ChooseBankAccount();
    }

    static void ViewProductDetails()
    {
        ChooseProduct();
    }

    static void RegisterStudent()
    {

    }

    static void CompareTowAccountBalances()
    {

    }

    static void RestockProduct()
    {

    }

    static void TransferBetweenAccounts()
    {

    }

    static void UpdateStudentGrade()
    {

    }

    static void StudentReportCard()
    {

    }

    static void AccountHealthStatus()
    {

    }

    static void BulkSale()
    {

    }

    static void ScholarshipEligibility()
    {

    }

    static void FullBalance()
    {

    }

    static void QuickAccountOpening()
    {

    }

    static void TotalStudents()
    {

    }

    static void OverdrawnAccountCheck()
    {

    }

    static void SetStudentSecurityPIN()
    {

    }



    static void Main(string[] args)
    {


        bool exit = false;

        while (exit == false)
        {

            Console.WriteLine("Main Menu");
            Console.WriteLine("1. View Account Details");
            Console.WriteLine("2. Update Student Address");
            Console.WriteLine("3. Make a Deposit");
            Console.WriteLine("4. Make a Withdrawal");
            Console.WriteLine("5. View Product Details");
            Console.WriteLine("6. Register Student");
            Console.WriteLine("7. Compare Account Balances");
            Console.WriteLine("8. Restock Product");
            Console.WriteLine("9. Transfer Between Accounts");
            Console.WriteLine("10. Update Student Grade");
            Console.WriteLine("11. Student Report Card");
            Console.WriteLine("12. Account Health Status");
            Console.WriteLine("13. Bulk Sale");
            Console.WriteLine("14. Scholarship Eligibility");
            Console.WriteLine("15. Full Balance Top-Up");
            Console.WriteLine("16. Quick Account Opening");
            Console.WriteLine("17. Total Students Counter");
            Console.WriteLine("18. Overdrawn Account Check");
            Console.WriteLine("19. Set Student Security PIN");
            Console.WriteLine("20. Exit");

            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewAccountDetails();
                    break;
                case 2:
                    UpdateStudentAddress();
                    break;
                case 3:
                    MakeDeposit();
                    break;
                case 4:
                    MakeWithdrawal();
                    break;
                case 5:
                    ViewProductDetails();
                    break;
                case 6:
                    RegisterStudent();
                    Console.WriteLine("Enter Student name: ");
                    student1.Name = Console.ReadLine();
                    Console.WriteLine("Enter Student address: ");
                    student1.Address = Console.ReadLine();
                    Console.WriteLine("Enter Student grade: ");
                    student1.Grade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter student email: ");
                    string email = Console.ReadLine();
                    student1.Register(email);

                    Console.WriteLine("Student registered successfully.");
                    
                    break;
                case 7:
                    CompareTowAccountBalances();
                    if (account1.Balance > account2.Balance)
                    {
                        Console.WriteLine($"{account1.HolderName} has the higher balance.");
                    }
                    else if (account2.Balance > account1.Balance)
                    {
                        Console.WriteLine($"{account2.HolderName} has the higher balance.");
                    }
                    else
                    {
                        Console.WriteLine("Both accounts have the same balance.");
                    }
                    break;
                case 8:
                    RestockProduct();
                    Console.Write("Enter quantity to restock: ");
                    int quantity = int.Parse(Console.ReadLine());

                    product1.Restock(quantity);

                    Console.WriteLine("Product restocked successfully.");
                    break;
                case 9:
                    TransferBetweenAccounts();
                    Console.Write("Enter transfer amount: ");
                    double amount = double.Parse(Console.ReadLine());

                    if (amount <= 0)
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    else if (account1.Balance < amount)
                    {
                        Console.WriteLine("Insufficient balance.");
                    }
                    else
                    {
                        account1.Withdraw(amount);
                        account2.Deposit(amount);

                        Console.WriteLine("Transfer completed successfully.");
                    }
                    break;
                case 10:
                    UpdateStudentGrade();
                    break;
                case 11:
                    StudentReportCard();
                    break;
                case 12:
                    AccountHealthStatus();
                    break;
                case 13:
                    BulkSale();
                    break;
                case 14:
                    ScholarshipEligibility();
                    break;
                case 15:
                    FullBalance();
                    break;
                case 16:
                    QuickAccountOpening();
                    break;
                case 17:
                    TotalStudents();
                    break;
                case 18:
                    OverdrawnAccountCheck();
                    break;
                case 19:
                    SetStudentSecurityPIN();
                    break;
                case 20:
                    exit = true;
                    Console.WriteLine("Thank you , have a good day!");
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }


    }

    static Student ChooseStudent()
    {
        Console.WriteLine("Choose Student 1 OR 2: ");
        int s = int.Parse(Console.ReadLine());
        if (s == 1)
        {
            return student1;
            
        }
        else if (s == 2)
        {
            return student2;
        }
        else
        {
            Console.WriteLine("Invalid option!");
            return student1;
        }
    }

    static void ChooseBankAccount()
    {

        Console.WriteLine("Choose Bank Account: ");
        string b = Console.ReadLine();
        
        Console.WriteLine("Enter deposit amount: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter withdraw amount: ");
        double w = double.Parse(Console.ReadLine());
        
        if (b == "1")
        {
            account1.Deposit(a);
            account1.Withdraw(w);
            Console.WriteLine("Holder name: "+account1.HolderName);
            Console.WriteLine("The balance is: " + account1.Balance);
            Console.WriteLine("The blance is: "+account1.Balance);
        }
        else if (b == "2")
        {
            account2.Deposit(a);
            Console.WriteLine("Holder name: "+account2.HolderName);
            Console.WriteLine("The balance is: " + account2.Balance);
        }
        else
        {
            Console.WriteLine("Invalid option!");
            
        }
    }

    static void ChooseProduct()
    {
        Console.WriteLine("Choose Product 1 OR 2: ");
        int p = int.Parse(Console.ReadLine());
        if (p == 1)
        {
            product1.GetInventoryValue();
        }
        else if (p == 2)
        {
            product2.GetInventoryValue();
        }
        else
        {
            Console.WriteLine("Invalid option!");
        }
    }



}

