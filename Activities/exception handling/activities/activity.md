Q0. Write a function called Divide that takes two integers as parameters and returns the result of dividing the first by the second. Handle exceptions like division by zero.

Basic Try-Catch:
Q1. Write a program that attempts to divide two numbers, numerator and denominator, inside a try block. Catch any DivideByZeroException that may occur and print an error message if it does.

Multiple Catch Blocks:
Q2. Modify the previous program to catch both DivideByZeroException and ArithmeticException. Print different error messages for each type of exception.

Finally Block:
Q3. Create a program that reads data from a file within a try block. Add a finally block to ensure that the file is always closed, regardless of whether an exception occurs or not.

Custom Exception:
Q4. Define a custom exception class, InvalidDataException, that inherits from Exception. Write a program that attempts to process some data and throws this custom exception if the data is invalid. Catch and handle the custom exception in the program.

Nested Try-Catch Blocks:
Q5. Write a program with nested try and catch blocks. Inside the inner try block, attempt to access an element in an array that is out of bounds. Catch the IndexOutOfRangeException in the inner catch block, and catch any other exceptions that may occur in the outer catch block.

Throwing Exceptions:
Q6. Create a program that reads a user's age and throws an exception if the age is negative or greater than 120. Catch the exception and print an error message.

Using finally for Cleanup:
Q7. Write a program that opens a database connection within a try block, performs some database operations, and closes the connection in a finally block to ensure proper cleanup, even if an exception occurs.

Handling AggregateException:
Q8. In a multithreaded application, use multiple threads to perform tasks concurrently. Catch and handle an AggregateException to manage exceptions that occur in parallel tasks.

Rethrowing Exceptions:
Q9. Write a program that calls a method that may throw an exception. Catch the exception and rethrow it with additional information using the throw statement.

Using using Statement:
Q10. Demonstrate the use of the using statement to automatically dispose of resources such as files or database connections. Create a program that reads data from a file using the StreamReader class within a using block.
