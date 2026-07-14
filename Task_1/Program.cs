// Task 1 - (Personal Info Card)

using System.Diagnostics;

string name= "Sara";
int age =20;
double height =1.65;
bool isStudent=true;
//display the output 
Console.WriteLine("Name: "+name);
Console.WriteLine("Age: "+age);
Console.WriteLine("Height: "+height);
Console.WriteLine("IsStudent: "+isStudent); 

//Task 2 - Rectangle Calculator
Console.WriteLine("Enter length");
double length = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter width");
double width = Convert.ToDouble(Console.ReadLine());
//calcalit and print the result 
double area = length * width;
double Perimeter = 2 * (length + width);
Console.WriteLine("Area: "+area);
Console.WriteLine("Perimeter: "+Perimeter);

//Task 3 - Even or Odd Checker
Console.WriteLine("Enter Number: ");
int number = Convert.ToInt32(Console.ReadLine());


//checking if it is ever or odd using if statment 
if (number % 2 == 0)
{
    Console.WriteLine("Number is even");
}
else
{
    Console.WriteLine("Number is odd!");
}

//Task 4 - Voting Eligibility

Console.WriteLine("Enter Age: ");
int age2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Do you have ID? (yes,no): ");
string id = Console.ReadLine();
bool hasID = false;
//cheking
if (id == "yse")
{
    hasID = true;
}

if (age2 >= 18 && hasID)
{
    Console.WriteLine("eligible to vote!");
}
else
{
    Console.WriteLine("not eligible to vote!");
}

//Task 5 - Grade Letter Lookup

Console.Write("Enter Your grade(A/B/C/D/F): ");
char grade = Convert.ToChar(Console.ReadLine());
switch (grade)
{
    case 'A':
        Console.WriteLine("Excellent");
        break;
    case 'B':
        Console.WriteLine("Very Good");
        break;
    case 'C':
        Console.WriteLine("Good");
        break;
    case 'D' :
        Console.WriteLine("Pass");
        break;
    case 'F' :
        Console.WriteLine("Fail");
        break;
    default:
        Console.WriteLine("Invalid grade");
        break;
}

//Task 6 - Temperature Converter
Console.Write("Enter Celsius: ");
double cel = Convert.ToDouble(Console.ReadLine());
double F =(cel * 9 / 5) + 32;
Console.WriteLine("Fahrenheit: " + F);
if (cel < 10)
{
    Console.WriteLine("Cold");
}
else if (cel <= 30)
{
    Console.WriteLine("Mild");
}
else
{
    Console.WriteLine("Hot");
}

//Task 7 - Movie Ticket Pricing

Console.Write("Enter age: ");
int mAge = Convert.ToInt32(Console.ReadLine());

if (mAge <= 12)
{
    Console.WriteLine("Child: 2 OMR");
}
else if (mAge <= 59)
{
    Console.WriteLine("Adult: 5 OMR");
}
else
{
    Console.WriteLine("Senior: 3 OMR");
}

//Task 8 - Restaurant Bill with Membership Discount

Console.Write("Enter bill: ");
double bill = Convert.ToDouble(Console.ReadLine());

Console.Write("Are you member? (yes/no): ");
string mem = Console.ReadLine();
bool isMember = false;

if (mem == "yes")
{
    isMember = true;
}

double discount = 0;
if (bill > 20 && isMember)
{
    discount = bill * 0.15;
}
double finalBill = bill - discount;

Console.WriteLine("Original Bill: " + bill);
Console.WriteLine("Discount: " + discount);
Console.WriteLine("Final Bill: " + finalBill);

//Task 9 - Day Name Finder

Console.Write("Enter day number (1-7): ");
int day = Convert.ToInt32(Console.ReadLine());
//Print the full day name using a
// switch-case statement.
switch (day)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;
    default:
        Console.WriteLine("Invalid day number");
        break;
}
//Task 10 - Mini Calculator 
Console.Write("Enter first number: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter operator (+ - * / %): ");
char op = Convert.ToChar(Console.ReadLine());

switch (op)
{
    case '+':
        Console.WriteLine(a + b);
        break;

    case '-':
        Console.WriteLine(a - b);
        break;

    case '*':
        Console.WriteLine(a * b);
        break;

    case '/':
        if (b != 0)
            Console.WriteLine(a / b);
        else
            Console.WriteLine("Cannot divide by zero");
        break;

    case '%':
        if (b != 0)
            Console.WriteLine(a % b);
        else
            Console.WriteLine("Cannot divide by zero");
        break;

    default:
        Console.WriteLine("Invalid operator");
        break;
}

// Task 11 - Loan Eligibility System
Console.Write("Enter age: ");
int lAge = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter income: ");
double income = Convert.ToDouble(Console.ReadLine());

Console.Write("Do you have loan? (yes/no): ");
string loan = Console.ReadLine();

bool hasLoan = false;

if (loan == "yes")
{
    hasLoan = true;
}

if (lAge >= 21 && lAge <= 60 && income >= 400 && !hasLoan)
{
    Console.WriteLine("Eligible for loan");
}
else
{
    Console.WriteLine("Not eligible for loan");
}
// Task 12 - Shipping Cost Calculator
Console.Write("Enter region (A/B/C): ");
char region = Convert.ToChar(Console.ReadLine());

Console.Write("Enter weight: ");
double weight = Convert.ToDouble(Console.ReadLine());

double baseCost = 0;
double extra = 0;
switch (region)
{
    case 'A':
        baseCost = 1;
        break;

    case 'B':
        baseCost = 3;
        break;

    case 'C':
        baseCost = 7;
        break;

    default:
        Console.WriteLine("Invalid region");
        return;
}

if (weight > 10)
{
    extra = 5;
}
else if (weight > 5)
{
    extra = 2;
}

Console.WriteLine("Base Cost: " + baseCost);
Console.WriteLine("Extra: " + extra);
Console.WriteLine("Total: " + (baseCost + extra));

//Task 13 - Triangle Type Classifier

Console.Write("Enter side 1: ");
double s1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter side 2: ");
double s2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter side 3: ");
double s3 = Convert.ToDouble(Console.ReadLine());
//
if (s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1)
{
    if (s1 == s2 && s2 == s3)
    {
        Console.WriteLine("Equilateral");
    }
    else if (s1 == s2 || s1 == s3 || s2 == s3)
    {
        Console.WriteLine("Isosceles");
    }
    else
    {
        Console.WriteLine("Scalene");
    }
}
else
{
    Console.WriteLine("Not a valid triangle");
}

//Task 14 - Online Store Checkout
Console.Write("Enter product code (1-3): ");
int product = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter quantity: ");
int qty = Convert.ToInt32(Console.ReadLine());

Console.Write("Coupon? (yes/no): ");
string coupon = Console.ReadLine();

bool hasCoupon = false;

if (coupon == "yes")
{
    hasCoupon = true;
}

double price = 0;

switch (product)
{
    case 1:
        price = 8.5;
        break;
    case 2:
        price = 12;
        break;
    case 3:
        price = 5;
        break;
    default:
        Console.WriteLine("Invalid product code");
        return;
}

double subtotal = price * qty;
double discount2 = 0;

if (hasCoupon && subtotal > 20)
{
    discount2 = subtotal * 0.10;
}

double afterDiscount = subtotal - discount2;
double tax = afterDiscount * 0.05;
double total = afterDiscount + tax;

Console.WriteLine("Subtotal: " + subtotal);
Console.WriteLine("Discount: " + discount2);
Console.WriteLine("Tax: " + tax);
Console.WriteLine("Total: " + total);


//Task 15 - University Admission Decision

Console.Write("Enter program (S/A): ");
char program = Convert.ToChar(Console.ReadLine());

Console.Write("Enter GPA: ");
double gpa = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter exam score: ");
double score = Convert.ToDouble(Console.ReadLine());

Console.Write("Extra activity? (yes/no): ");
string extraa = Console.ReadLine();

bool hasExtra = false;

if (extraa == "yes")
{
    hasExtra = true;
}

if (program == 'S')
{
    if (gpa >= 3.0 && score >= 75)
    {
        Console.WriteLine("Admitted - Science");
    }
    else if (hasExtra)
    {
        Console.WriteLine("Conditionally Admitted - Science");
    }
    else
    {
        Console.WriteLine("Not Admitted - Science");
    }
}
else if (program == 'A')
{
    if (gpa >= 2.5 && score >= 60)
    {
        Console.WriteLine("Admitted - Arts");
    }
    else if (hasExtra)
    {
        Console.WriteLine("Conditionally Admitted - Arts");
    }
    else
    {
        Console.WriteLine("Not Admitted - Arts");
    }
}
else
{
    Console.WriteLine("Invalid program type");
}