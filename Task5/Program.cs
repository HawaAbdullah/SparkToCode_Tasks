namespace Task5;

class Program

{
    // Function to remove a print job from the queue
    static Queue<string> RemoveJob(Queue<string> queue, string jobName)
    {
        Queue<string> updatedQueue = new Queue<string>();


        // Move jobs except the one to remove
        while (queue.Count > 0)
        {
            string currentJob = queue.Dequeue();

            if (currentJob != jobName)
            {
                updatedQueue.Enqueue(currentJob);
            }
        }

        return updatedQueue;
    }

    static void Main(string[] args)
    {
        // Create an array with fixed size of 5 integers to store grades
        int[] grades = new int[5];


        // Use for loop to get grades from user
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write("Enter grade " + (i + 1) + ": ");
            grades[i] = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("\nStudent Grades:");


        // Use foreach loop to print all grades
        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }
        
        // Create a List to store to-do tasks
        List<string> tasks = new List<string>();


        // Ask the user to enter 5 tasks and add them to the list
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter task " + (i + 1) + ": ");
            string task = Console.ReadLine();

            tasks.Add(task);
        }


        Console.WriteLine("\nYour To-Do List:");

            
        // Print all tasks using foreach loop
        foreach (string task in tasks)
        {
            Console.WriteLine("- " + task);
        }
        // Create a Stack to store browser history
        Stack<string> history = new Stack<string>();


        // Ask the user to enter 3 website URLs
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter website URL " + (i + 1) + ": ");
            string url = Console.ReadLine();

            // Add website to the stack
            history.Push(url);
        }


        Console.WriteLine("\nBrowser History:");

        // Display current history
        foreach (string page in history)
        {
            Console.WriteLine(page);
        }


        // Simulate pressing the Back button
        string currentPage = history.Pop();


        Console.WriteLine("\nBack button pressed...");
        Console.WriteLine("You returned from: " + currentPage);


        Console.WriteLine("You are now on: " + history.Peek());
        
        // Create a Queue to store customer names
        Queue<string> customers = new Queue<string>();


        // Ask the user to enter 3 customer names
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter customer name " + (i + 1) + ": ");
            string name = Console.ReadLine();

            // Add customer to the queue
            customers.Enqueue(name);
        }


        Console.WriteLine("\nCustomers Waiting:");

        // Display customers in the queue
        foreach (string customer in customers)
        {
            Console.WriteLine(customer);
        }


        // Serve the first customer
        string servedCustomer = customers.Dequeue();


        Console.WriteLine("\nCustomer Served:");
        Console.WriteLine(servedCustomer);


        Console.WriteLine("\nRemaining Customers:");

        foreach (string customer in customers)
        {
            Console.WriteLine(customer);
        }
        
        // Create an array to store 5 grades
        int[] g = new int[5];


        // Get grades from user
        for (int i = 0; i < g.Length; i++)
        {
            Console.Write("Enter grade " + (i + 1) + ": ");
            g[i] = int.Parse(Console.ReadLine());
        }


        // Sort the array from smallest to largest
        Array.Sort(g);


        // Calculate total of grades
        int sum = 0;

        for (int i = 0; i < g.Length; i++)
        {
            sum += g[i];
        }


        // Calculate average
        double average = sum / 5.0;


        // Print results
        Console.WriteLine("\nGrade Results:");

        Console.WriteLine("Lowest Grade: " + g[0]);

        Console.WriteLine("Highest Grade: " + g[g.Length - 1]);

        Console.WriteLine("Average: " + average);
        
        // Create a shopping list
        List<string> shoppingList = new List<string>();


        // Variable to store user input
        string item = "";


        // Keep asking the user until they type "done"
        while (item.ToLower() != "done")
        {
            Console.Write("Enter shopping item (or type done to finish): ");
            item = Console.ReadLine();

            // Add the item only if it is not "done"
            if (item.ToLower() != "done")
            {
                shoppingList.Add(item);
            }
        }


        // Print shopping list before removing an item
        Console.WriteLine("\nShopping List Before Removal:");

        foreach (string product in shoppingList)
        {
            Console.WriteLine("- " + product);
        }


        // Ask the user which item to remove
        Console.Write("\nEnter an item to remove: ");
        string removeItem = Console.ReadLine();


        // Remove the item from the list
        shoppingList.Remove(removeItem);


        // Print shopping list after removing the item
        Console.WriteLine("\nShopping List After Removal:");

        foreach (string product in shoppingList)
        {
            Console.WriteLine("- " + product);
        }
        
        // Create a list to store game scores
        List<int> scores = new List<int>();


        // Ask the user to enter 5 scores
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter score " + (i + 1) + ": ");
            int score = int.Parse(Console.ReadLine());

            scores.Add(score);
        }


        // Sort scores in ascending order
        scores.Sort();


        // Reverse the list to make it descending
        scores.Reverse();


        // Print the top 3 scores
        Console.WriteLine("\nTop 3 Scores:");

        Console.WriteLine("1st Place: " + scores[0]);
        Console.WriteLine("2nd Place: " + scores[1]);
        Console.WriteLine("3rd Place: " + scores[2]);
        
        // Create a stack to store editor actions
        Stack<string> actions = new Stack<string>();


        // Variable to store user input
        string action = "";


        // Keep asking for actions until the user types "stop"
        while (action.ToLower() != "stop")
        {
            Console.Write("Enter an action (or type stop to finish): ");
            action = Console.ReadLine();

            // Add the action to the stack if it is not "stop"
            if (action.ToLower() != "stop")
            {
                actions.Push(action);
            }
        }


        // Undo the last action
        if (actions.Count > 0)
        {
            Console.WriteLine("\nFirst Undo: " + actions.Pop());
        }

        // Undo the second last action
        if (actions.Count > 0)
        {
            Console.WriteLine("Second Undo: " + actions.Pop());
        }


        // Print remaining actions
        Console.WriteLine("\nRemaining Actions:");

        foreach (string itemm in actions)
        {
            Console.WriteLine(itemm);
        }
        
        // Function to calculate the average of all grades
        static double CalculateAverage(List<int> grades)
        {
            int sum = 0;

            for (int i = 0; i < grades.Count; i++)
            {
                sum += grades[i];
            }

            return (double)sum / grades.Count;
        }


        // Function to find the first failing grade
        static int FindFirstFailing(List<int> grades)
        {
            return grades.Find(x => x < 60);
        }


        static void Main(string[] args)
        {

            // Create a list to store grades
            List<int> grades = new List<int>();


            // Ask the user how many grades they want to enter
            Console.Write("How many grades do you want to enter? ");
            int numberOfGrades = int.Parse(Console.ReadLine());


            // Read grades from the user
            for (int i = 0; i < numberOfGrades; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades.Add(int.Parse(Console.ReadLine()));
            }


            // Call CalculateAverage function
            double average = CalculateAverage(grades);

            Console.WriteLine("\nAverage Grade: " + average);


            // Call FindFirstFailing function
            int failingGrade = FindFirstFailing(grades);


            if (failingGrade == 0)
            {
                Console.WriteLine("No failing grades found.");
            }
            else
            {
                Console.WriteLine("First Failing Grade: " + failingGrade);
            }


            }
        // Create a print queue
        Queue<string> printQueue = new Queue<string>();


        // Read print jobs from the user
        while (true)
        {
            Console.Write("Enter print job (or type done): ");
            string job = Console.ReadLine();

            if (job.ToLower() == "done")
            {
                break;
            }

            printQueue.Enqueue(job);
        }


        // Print queue before removing a job
        Console.WriteLine("\nPrint Queue Before Removal:");

        foreach (string i in printQueue)
        {
            Console.WriteLine(item);
        }


        // Ask the user which job to remove
        Console.Write("\nEnter job name to cancel: ");
        string removeJob = Console.ReadLine();


        // Call RemoveJob function
        printQueue = RemoveJob(printQueue, removeJob);


        // Print queue after removing a job
        Console.WriteLine("\nPrint Queue After Removal:");

        foreach (string i in printQueue)
        {
            Console.WriteLine(item);
        }


    }
}