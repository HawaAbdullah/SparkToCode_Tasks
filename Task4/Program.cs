namespace Task4;

class Program
{
    static void PrintWelcome(string name)
    {
        Console.WriteLine("Welcome " + name + " to C# Programming!");
    }
    // Function that calculates the square of a number
    // It takes an integer parameter and returns an integer value
    static int Square(int number)
    {
        return number * number;
    }
    
    // Function that converts Celsius temperature to Fahrenheit
    // It takes a double parameter and returns a double value
    static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9 / 5) + 32;

        return fahrenheit;
    }
    // Function that displays a fixed menu
    // It takes no parameters and returns nothing
    static void DisplayMenu()
    {
        Console.WriteLine("===== Menu =====");
        Console.WriteLine("1) Start");
        Console.WriteLine("2) Help");
        Console.WriteLine("3) Exit");
        Console.WriteLine("================");
    }

    // Function that checks if a number is even
    // It takes an integer parameter and returns a boolean value
    static bool IsEven(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    // Function that calculates rectangle area
    // Takes two double parameters and returns double
    static double CalculateArea(double length, double width)
    {
        return length * width;
    }


    // Function that calculates rectangle perimeter
    // Takes two double parameters and returns double
    static double CalculatePerimeter(double length, double width)
    {
        return 2 * (length + width);
    }
    
    // Function that returns the grade letter based on score
    // Takes an integer parameter and returns a string
    static string GetGradeLetter(int score)
    {
        if (score >= 90)
        {
            return "A";
        }
        else if (score >= 80)
        {
            return "B";
        }
        else if (score >= 70)
        {
            return "C";
        }
        else if (score >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }

    // Function that prints countdown numbers
    // It takes one integer parameter and returns nothing
    static void Countdown(int startNumber)
    {
        for (int i = startNumber; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Finished!");
    }
    
    // Multiply two integers
    static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }


    // Multiply two double numbers
    static double Multiply(double number1, double number2)
    {
        return number1 * number2;
    }


    // Multiply three integers
    static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }
    
    
    // Calculate square area
    // Takes one double parameter
    static double CalculateArea(double side)
    {
        return side * side;
    }


    // Calculate rectangle area
    // Takes two double parameters
    static double CalculateAreaa(double leng, double wid)
    {
        return leng * wid;
    }
    
    // Function to add two numbers
    static double Add(double number1, double number2)
    {
        return number1 + number2;
    }


    // Function to subtract two numbers
    static double Subtract(double number1, double number2)
    {
        return number1 - number2;
    }


    // Function to multiply two numbers
    static double MultiplyNumbers(double number1, double number2)
    {
        return number1 * number2;
    }


    // Function to divide two numbers
    static double DivideNumbers(double number1, double number2)
    {
        try
        {
            return number1 / number2;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
            return 0;
        }
    }


    // Function to display result
    static void DisplayResult(string operation, double result)
    {
        Console.WriteLine(operation + " Result = " + result);
    }
    
    
    // Function to calculate the average of three scores
    // Takes three double parameters and returns double
    static double CalculateAverage(double score1, double score2, double score3)
    {
        return (score1 + score2 + score3) / 3;
    }


    // Function to determine grade letter
    // Takes average and returns grade
    static string GetGradeLetter(double average)
    {
        if (average >= 90)
        {
            return "A";
        }
        else if (average >= 80)
        {
            return "B";
        }
        else if (average >= 70)
        {
            return "C";
        }
        else if (average >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }


    // Function to print final report card
    // Takes name, average, and grade
    static void PrintReportCard(string name, double average, string grade)
    {
        Console.WriteLine("======================");
        Console.WriteLine("Student Report Card");
        Console.WriteLine("======================");

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Grade: " + grade);

        Console.WriteLine("======================");
    }
    
    static void Main(string[] args)
    {
        // Ask the user for their name
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        // Call the function and pass the user's name
        PrintWelcome(userName);
        
        // Ask the user to enter a number
        Console.Write("Enter a number: ");
        int userNumber = int.Parse(Console.ReadLine());

        // Call the function and store the returned result
        int result = Square(userNumber);

        // Print the result in Main
        Console.WriteLine("Square = " + result);
        
        // Ask the user to enter temperature in Celsius
        Console.Write("Enter temperature in Celsius: ");
        double celsiusValue = double.Parse(Console.ReadLine());

        // Call the function and store the returned value
        double fahrenheitValue = CelsiusToFahrenheit(celsiusValue);

        // Print the result in Main
        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheitValue);
        
        // Call the function to display the menu
        DisplayMenu();
        
        // Ask the user to enter a number
        Console.Write("Enter a number: ");
        int userNum = int.Parse(Console.ReadLine());

        // Call the function and store the returned value
        bool res = IsEven(userNum);

        // Use if-else in Main to print the result
        if (res)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
        
        // Ask the user for rectangle length
        Console.Write("Enter length: ");
        double length = double.Parse(Console.ReadLine());

        // Ask the user for rectangle width
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());


        // Call both functions
        double area = CalculateArea(length, width);
        double perimeter = CalculatePerimeter(length, width);


        // Print the results in Main
        Console.WriteLine("Area = " + area);
        Console.WriteLine("Perimeter = " + perimeter);
        
        // Ask the user to enter the score
        Console.Write("Enter your score: ");
        int score = int.Parse(Console.ReadLine());


        // Call the function and store the returned grade
        string grade = GetGradeLetter(score);


        // Print the result in Main
        Console.WriteLine("Grade: " + grade);
        
        // Ask the user for the starting number
        Console.Write("Enter starting number: ");
        int number = int.Parse(Console.ReadLine());


        // Call the countdown function
        Countdown(number);
        
        // Call Multiply with two int parameters
        int result1 = Multiply(5, 4);
        Console.WriteLine("Two integers result: " + result1);


        // Call Multiply with two double parameters
        double result2 = Multiply(2.5, 4.0);
        Console.WriteLine("Two doubles result: " + result2);


        // Call Multiply with three int parameters
        int result3 = Multiply(2, 3, 4);
        Console.WriteLine("Three integers result: " + result3);
        
        Console.WriteLine("Choose shape:");
        Console.WriteLine("1) Square");
        Console.WriteLine("2) Rectangle");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());


        if (choice == 1)
        {
            // Read square side
            Console.Write("Enter side length: ");
            double side = double.Parse(Console.ReadLine());


            // Call square overload
            double areaa = CalculateArea(side);


            Console.WriteLine("Square Area = " + area);
        }
        else if (choice == 2)
        {
            // Read rectangle dimensions
            Console.Write("Enter length: ");
            double leng = double.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            double wid = double.Parse(Console.ReadLine());


            // Call rectangle overload
            double areaa = CalculateAreaa(leng, wid);


            Console.WriteLine("Rectangle Area = " + area);
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
        
         bool running = true;


            while (running)
            {

                Console.WriteLine("================");
                Console.WriteLine("Calculator Menu");
                Console.WriteLine("1) Add");
                Console.WriteLine("2) Subtract");
                Console.WriteLine("3) Multiply");
                Console.WriteLine("4) Divide");
                Console.WriteLine("5) Exit");
                Console.WriteLine("================");


                Console.Write("Choose operation: ");
                int choic = int.Parse(Console.ReadLine());


                if (choic == 5)
                {
                    running = false;
                    Console.WriteLine("Calculator Closed");
                    break;
                }


                Console.Write("Enter first number: ");
                double n1 = double.Parse(Console.ReadLine());


                Console.Write("Enter second number: ");
                double n2 = double.Parse(Console.ReadLine());


                double resultt = 0;


                switch (choic)
                {
                    case 1:

                        resultt = Add(n1, n2);
                        DisplayResult("Addition", resultt);

                        break;


                    case 2:

                        resultt = Subtract(n1, n2);
                        DisplayResult("Subtraction", resultt);

                        break;


                    case 3:

                        resultt = MultiplyNumbers(n1, n2);
                        DisplayResult("Multiplication", resultt);

                        break;


                    case 4:

                        resultt = DivideNumbers(n1, n2);
                        DisplayResult("Division", resultt);

                        break;


                    default:

                        Console.WriteLine("Invalid choice");

                        break;
                }

            }
            // Ask student information
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();


            Console.Write("Enter first score: ");
            double score1 = double.Parse(Console.ReadLine());


            Console.Write("Enter second score: ");
            double score2 = double.Parse(Console.ReadLine());


            Console.Write("Enter third score: ");
            double score3 = double.Parse(Console.ReadLine());


            // Calculate average
            double average = CalculateAverage(score1, score2, score3);


            // Get grade letter
            string gradee = GetGradeLetter(average);


            // Print report card
            PrintReportCard(studentName, average, grade);



        
    }
}