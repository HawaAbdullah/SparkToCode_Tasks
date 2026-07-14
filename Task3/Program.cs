namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        //Task 1
        //Ask user to enter first number
        Console.Write("Enter The First Number: ");
        double FirstNumber = double.Parse(Console.ReadLine());
        
        //Ask user to enter the secound number
        Console.Write("Enter the Second Numver: ");
        double SecondNumber = double.Parse(Console.ReadLine());
        
        //make calculation (subtract ) 
        double diff = FirstNumber - SecondNumber;
        Console.WriteLine($"The difference is : {diff}");
        
        //To make the ruslt always Positive.
        double result = Math.Abs(diff);
        Console.WriteLine($"The Absolute difftent is: {result}");
        
        //Task 2
        Console.Write("Enter a number: ");
        double num = double.Parse(Console.ReadLine());

        double sq = Math.Sqrt(num);
        Console.WriteLine($"The sqrt is :{sq}");

        double pow = Math.Pow(num,2);
        Console.WriteLine($"The Power or the number is {pow}");
        
        //Task 3 
        // Ask user to enter full name
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();
        //Conver the name to upper and lower case
        string fullName1 = fullName.ToLower();
        string fullName2 = fullName.ToUpper();
        Console.WriteLine($"Lower {fullName} is {fullName1}");
        Console.WriteLine($"Upper {fullName} is {fullName2}");
        
        //Count number of characters
        int length = fullName.Length;
        Console.WriteLine($"The length is {length}");
        
        //Task 4
        //Ask the user to enter the free trial period in days
        Console.Write("Enter the number of free trial days: ");
        int trialDays = int.Parse(Console.ReadLine());

        //Get today's date
        DateTime startDate = DateTime.Today;
        
        //Calculate the subscription end date
        DateTime endDate = startDate.AddDays(trialDays); 
        //Display the end date in yyyy-MM-dd format
        Console.WriteLine("Subscription End Date: " + endDate.ToString("yyyy-MM-dd"));

        //Task 5
        //Ask the user to enter the exam score
        Console.WriteLine("Enter your exam scor: ");
        double score = double.Parse(Console.ReadLine());
        
        double roundedScore = Math.Round(score);
       
        Console.WriteLine($"Your score is {roundedScore}");

        if (roundedScore >= 67)
        {
            Console.WriteLine("Student :Pass");
        }
        else
        {
            Console.WriteLine("Student :Fail");
        }
        
        //Task 6
        
        // Ask the user to enter a password
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        // Check if the password has at least 8 characters
        bool hasValidLength = password.Length >= 8;

        // Check if the password contains the forbidden word
        bool containsForbiddenWord = password.ToLower().Contains("password");

        // Check if the password is strong
        if (hasValidLength && !containsForbiddenWord)
        {
            Console.WriteLine("Strong Password");
        }
        else
        {
            Console.WriteLine("Weak Password");

            if (!hasValidLength)
            {
                Console.WriteLine("Reason: Password must be at least 8 characters long.");
            }

            if (containsForbiddenWord)
            {
                Console.WriteLine("Reason: Password must not contain the word 'password'.");
            }

            //Task 7
            // Ask the user to enter the first name
            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();

            // Ask the user to enter the second name
            Console.Write("Enter the second name: ");
            string secondName = Console.ReadLine();

            // Remove extra spaces and ignore letter case
            firstName = firstName.Trim().ToUpper();
            secondName = secondName.Trim().ToUpper();

            // Compare the two names
            if (firstName == secondName)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }
        }
        
        //Task 8 
        try
        {
            // Ask the user to enter the membership start date
            Console.Write("Enter membership start date (yyyy-MM-dd): ");
            DateTime SDate = DateTime.Parse(Console.ReadLine());

            // Ask the user to enter the membership duration
            Console.Write("Enter membership days: ");
            int membershipDays = int.Parse(Console.ReadLine());

            // Calculate the expiry date
            DateTime expiryDate = SDate.AddDays(membershipDays);

            // Display the expiry date
            Console.WriteLine("Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));

            // Check if the membership is still active
            if (expiryDate >= DateTime.Today)
            {
                Console.WriteLine("Membership Status: Active");
            }
            else
            {
                Console.WriteLine("Membership Status: Expired");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid date or number format.");
        }
        //Task 9
        
        Console.Write("Enter a decimal number: ");
        double n = double.Parse(Console.ReadLine());
        
        
        double rouned = Math.Round(n);

        
        double roundUp = Math.Ceiling(n);

        
        double rounDown = Math.Floor(n);

        //Display the results
        Console.WriteLine("Nearest Whole Number: " + rouned);
        Console.WriteLine("Rounded Up: " + roundUp);
        Console.WriteLine("Rounded Down: " + rounDown);
        
        
        // Ask the user to enter a decimal number
        Console.Write("Enter a decimal number: ");
        double number = double.Parse(Console.ReadLine());

        // Round to the nearest whole number
        double rounded = Math.Round(number);

        // Always round up
        double roundedUp = Math.Ceiling(number);

        // Always round down
        double roundedDown = Math.Floor(number);

        // Display the results
        Console.WriteLine("Nearest Whole Number: " + rounded);
        Console.WriteLine("Rounded Up: " + roundedUp);
        Console.WriteLine("Rounded Down: " + roundedDown);
        
        // Task 10 - Word Position Finder
        
        // Ask the user to enter a sentence
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        // Ask the user to enter a word to search for
        Console.Write("Enter a word to search: ");
        string word = Console.ReadLine();

        // Find the first occurrence of the word
        int firstPosition = sentence.IndexOf(word);

        // Find the last occurrence of the word
        int lastPosition = sentence.LastIndexOf(word);

        // Check if the word exists
        if (firstPosition == -1)
        {
            Console.WriteLine("Word not found");
        }
        else
        {
            Console.WriteLine("First occurrence position: " + firstPosition);
            Console.WriteLine("Last occurrence position: " + lastPosition);
        }






    }
}