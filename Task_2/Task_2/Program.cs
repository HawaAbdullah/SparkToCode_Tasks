namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Countdown Timer

        // Ask the user to enter the starting number
        Console.Write("Enter the starting number: ");
        int startNumber = int.Parse(Console.ReadLine());

        // Count down from the starting number to 1
        for (int i = startNumber; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        // Print the final message after the countdown ends
        Console.WriteLine("Liftoff!");
        
        //Task 2 - Sum of Numbers from 1 to N

        
        Console.Write("Enter a positive number: ");
        int number = int.Parse(Console.ReadLine());

        
        int sum = 0;

        //Add every number from 1 to N
        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }

        // Display the final sum
        Console.WriteLine("Sum = " + sum);
        
        //Task 3 - Multiplication Table

        // Ask the user to enter a number
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        // Print the multiplication table from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
        //Task 4 - Password Retry

        // Store the correct password
        string correctPassword = "Spark2026";

        // Variable to store user input
        string userPassword = "";

        // Keep asking until the correct password is entered
        while (userPassword != correctPassword)
        {
            Console.Write("Enter password: ");
            userPassword = Console.ReadLine();

            // Check if the password is correct
            if (userPassword == correctPassword)
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Incorrect password, try again");
            }
        }
        // Task 5 - Number Guessing Game

        // Fixed secret number
        int secretNumber = 42;

        // Store user's guess
        int guess;

        // Count number of attempts
        int attempts = 0;


        do
        {
            // Ask user for a guess
            Console.Write("Guess the number: ");
            guess = int.Parse(Console.ReadLine());

            // Increase attempts after each try
            attempts++;

            // Compare the guess with the secret number
            if (guess > secretNumber)
            {
                Console.WriteLine("Too high");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too low");
            }
            else
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("Attempts: " + attempts);
            }

        } while (guess != secretNumber);
        
        // Task 6 - Safe Division Calculator

        try
        {
            // Get numbers from user
            Console.Write("Enter first number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double number2 = double.Parse(Console.ReadLine());


            // Division operation
            double result = number1 / number2;


            // Display result
            Console.WriteLine("Result = " + result);
        }


        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }


        catch (FormatException)
        {
            Console.WriteLine("Please enter valid numbers");
        }
        
        // Task 7 - Repeating Menu with Exit Option

        // Variable to store user choice
        int choice = 0;


        // Keep showing menu until user chooses Exit
        while (choice != 3)
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1) Say Hello");
            Console.WriteLine("2) Show Greeting");
            Console.WriteLine("3) Exit");
            Console.Write("Choose an option: ");


            try
            {
                // Convert user input to integer
                choice = int.Parse(Console.ReadLine());


                // Handle menu options
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hello!");
                        break;


                    case 2:
                        Console.WriteLine("Good morning, have a nice day!");
                        break;


                    case 3:
                        Console.WriteLine("Exiting program...");
                        break;


                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }


            catch (FormatException)
            {
                Console.WriteLine("Please enter a number only");
            }


            Console.WriteLine();
        }
        
        // Task 8 - Sum of Even Numbers Only


        // Ask user for a positive number
        Console.Write("Enter a positive number: ");
        int num = int.Parse(Console.ReadLine());


        // Variable to store the sum
        int s = 0;


        // Loop from 1 to N
        for (int i = 1; i <= num; i++)
        {

            // Check if the number is even
            if (i % 2 == 0)
            {
                // Add even number to total
                sum += i;
            }

        }


        // Print final sum
        Console.WriteLine("Sum of even numbers = " + sum);
        
        // Task 9 - Validated Positive Number Input


        int nu = 0;


        // Keep asking until the user enters a valid positive number
        do
        {
            try
            {
                // Ask user for input
                Console.Write("Enter a positive whole number: ");

                nu = int.Parse(Console.ReadLine());


                // Check if number is zero or negative
                if (nu <= 0)
                {
                    Console.WriteLine("Number must be positive");
                }

            }


            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a whole number");
                nu = 0;
            }


        } while (nu <= 0);



        // Calculate the sum from 1 to the valid number
        int su = 0;


        for (int i = 1; i <= nu; i++)
        {
            su += i;
        }


        // Display the final result
        Console.WriteLine("Sum = " + su);
        
        // Task 10 - Simple ATM Simulation


            int correctPin = 1234;
            double balance = 100.000;


            int attempt = 0;
            bool pinCorrect = false;



            // Allow user maximum 3 PIN attempts
            while (attempt < 3)
            {
                try
                {
                    Console.Write("Enter PIN: ");

                    int pin = int.Parse(Console.ReadLine());


                    if (pin == correctPin)
                    {
                        pinCorrect = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong PIN");
                    }

                }

                catch (FormatException)
                {
                    Console.WriteLine("Invalid PIN");
                }


                attempt++;
            }



            // If PIN is incorrect after 3 attempts
            if (pinCorrect == false)
            {
                Console.WriteLine("Card Blocked");
                return;
            }



            int choicee = 0;


            // ATM menu
            while (choicee != 4)
            {
                Console.WriteLine();
                Console.WriteLine("===== ATM MENU =====");
                Console.WriteLine("1) Deposit");
                Console.WriteLine("2) Withdraw");
                Console.WriteLine("3) Check Balance");
                Console.WriteLine("4) Exit");


                try
                {
                    Console.Write("Choose option: ");
                    choicee = int.Parse(Console.ReadLine());


                    switch (choicee)
                    {

                        case 1:

                            Console.Write("Enter deposit amount: ");
                            double deposit = double.Parse(Console.ReadLine());


                            if (deposit > 0)
                            {
                                balance += deposit;
                                Console.WriteLine("Balance = " + balance);
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount");
                            }

                            break;



                        case 2:

                            Console.Write("Enter withdrawal amount: ");
                            double withdraw = double.Parse(Console.ReadLine());


                            if (withdraw <= 0)
                            {
                                Console.WriteLine("Invalid amount");
                            }

                            else if (withdraw > balance)
                            {
                                Console.WriteLine("Insufficient balance");
                            }

                            else
                            {
                                balance -= withdraw;
                                Console.WriteLine("Balance = " + balance);
                            }

                            break;



                        case 3:

                            Console.WriteLine("Current Balance = " + balance);
                            break;



                        case 4:

                            Console.WriteLine("Thank you for using ATM");
                            break;



                        default:

                            Console.WriteLine("Invalid option");
                            break;
                    }

                }


                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid numbers");
                }

            }

        
        
        
    }
}