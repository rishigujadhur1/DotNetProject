// 0
public void PrintNumbers(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i);
    }
}

// // 1
// Calculate Factorial:
// You can calculate the factorial of a number n using a for loop as follows:
public static long CalculateFactorial(int n)
{
    long factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial *= i;
    }
    return factorial;
}

// // 2 Print Multiplication Table:
// Here's a program that prints the multiplication table for a given number using a for loop:
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}");
}

// 3. While Loop Activities:

// Guess the Number:
// Here's a program that lets the user guess a random number using a while loop:

Random random = new Random();
int targetNumber = random.Next(1, 101);
int attempts = 0;

while (true)
{
    Console.Write("Guess the number: ");
    int guess = int.Parse(Console.ReadLine());
    attempts++;

    if (guess == targetNumber)
    {
        Console.WriteLine($"Congratulations! You guessed it in {attempts} attempts.");
        break;
    }
    else if (guess < targetNumber)
    {
        Console.WriteLine("Try a higher number.");
    }
    else
    {
        Console.WriteLine("Try a lower number.");
    }
}

// 4. Sum of Digits:
// You can calculate the sum of the digits of an integer using a while loop as follows
public static int SumOfDigits(int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

//5. Foreach Loop Activities:

// Find Maximum Value:
// Here's a function that finds the maximum value in an array of integers using a foreach loop:
public static int FindMaxValue(int[] numbers)
{
    int max = numbers[0]; // Assume the first element is the maximum
    foreach (int num in numbers)
    {
        if (num > max)
        {
            max = num;
        }
    }
    return max;
}

//6. Average of Grades:
// You can calculate the average of grades entered by the user using a foreach loop as follows:
List<int> grades = new List<int>();
// Populate the 'grades' list with user input
// ...

int sum = 0;
foreach (int grade in grades)
{
    sum += grade;
}
double average = (double)sum / grades.Count;
Console.WriteLine($"Average Grade: {average:F2}");

// 7. Do-While Loop Activities:

// User Menu with Do-While:
// Here's a program that displays a menu to the user using a do-while loop:
int choice;
do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Quit");
    Console.Write("Enter your choice: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("You selected Add.");
            break;
        case 2:
            Console.WriteLine("You selected Subtract.");
            break;
        case 3:
            Console.WriteLine("Exiting the program.");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
} while (choice != 3);

// 8. Factorial with Do-While:
// You can calculate the factorial of a number n using a do-while loop as follows:
public static long CalculateFactorialWithDoWhile(int n)
{
    long factorial = 1;
    int i = 1;
    do
    {
        factorial *= i;
        i++;
    } while (i <= n);
    return factorial;
}
