// 0
public double Divide(int dividend, int divisor)
{
    try
    {
        return (double)dividend / divisor;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Division by zero is not allowed.");
        return double.NaN; // Not-a-Number
    }
}


// Basic Try-Catch:
// A1. You can write a program like this:

try
{
    int numerator = 10;
    int denominator = 0;
    int result = numerator / denominator; // Attempt division by zero
    Console.WriteLine("Result: " + result);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}

// Multiple Catch Blocks:
// A2. You can modify the program to catch multiple exceptions:
try
{
    int numerator = 10;
    int denominator = 0;
    int result = numerator / denominator; // Attempt division by zero
    Console.WriteLine("Result: " + result);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("DivideByZeroException: " + ex.Message);
}
catch (ArithmeticException ex)
{
    Console.WriteLine("ArithmeticException: " + ex.Message);
}

// Finally Block:
// A3. You can create a program like this:
FileStream fileStream = null;
try
{
    fileStream = new FileStream("data.txt", FileMode.Open);
    // Read data from the file
}
catch (IOException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    if (fileStream != null)
        fileStream.Close(); // Ensure the file is closed, even if an exception occurs
}

// Custom Exception:
// A4. Define a custom exception class like this:
public class InvalidDataException : Exception
{
    public InvalidDataException(string message) : base(message)
    {
    }
}

// Then, write a program that uses this custom exception:
try
{
    // Process data and detect invalid data
    throw new InvalidDataException("Invalid data detected.");
}
catch (InvalidDataException ex)
{
    Console.WriteLine("Custom Exception: " + ex.Message);
}

// Nested Try-Catch Blocks:
// A5. You can create nested try-catch blocks like this:
try
{
    try
    {
        int[] numbers = { 1, 2, 3 };
        int value = numbers[10]; // Accessing an out-of-bounds element
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine("Inner Exception: " + ex.Message);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Outer Exception: " + ex.Message);
}

// Throwing Exceptions:
// A6. Write a program that reads a user's age and throws an exception if it's negative or greater than 120:
try
{
    int age = /* Input from user */;
    if (age < 0 || age > 120)
    {
        throw new Exception("Invalid age.");
    }
    Console.WriteLine("Valid age: " + age);
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}

// Using finally for Cleanup:
// A7. Create a program that opens a database connection within a try block, performs some database operations, and closes the connection in a finally block:
SqlConnection connection = null;
try
{
    connection = new SqlConnection("connectionString");
    connection.Open();
    // Perform database operations
}
finally
{
    if (connection != null)
    {
        connection.Close();
    }
}

// Handling AggregateException:
// A8. In a multithreaded application, you can use Task.WhenAll to run multiple tasks concurrently and then use AggregateException to handle exceptions that may occur in parallel tasks.

// Rethrowing Exceptions:
// A9. Write a program that calls a method that may throw an exception and rethrow it with additional information:
try
{
    DoSomething();
}
catch (Exception ex)
{
    throw new Exception("An error occurred while doing something.", ex);
}

// Using using Statement:
// A10. You can use the using statement to read data from a file and automatically dispose of resources:
using (StreamReader reader = new StreamReader("data.txt"))
{ string line; while ((line = reader.ReadLine()) != null) { Console.WriteLine(line); } }