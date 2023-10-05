1 Arithmetic Operators:
A1. To calculate a divided by b, you can use the division operator /. To handle division by zero, you should include an if statement to check if b is zero before performing the division.

2. Assignment Operators:
   A2. You can update the value of x using assignment operators as follows:

int x = 10;
x += 5; // x is now 15
x += 5; // x is now 20

3. Comparison Operators:
   A3. The program can use comparison operators to compare num1 and num2 and print appropriate messages. For example:

if (num1 == num2)
{
Console.WriteLine("num1 is equal to num2");
}
else if (num1 > num2)
{
Console.WriteLine("num1 is greater than num2");
}
else
{
Console.WriteLine("num1 is less than num2");
}

4. Logical Operators:

A4. You can use logical operators to check both conditions and print the message if both are true. For example:

if (isSunny && isWarm)
{
Console.WriteLine("Good day for a picnic");
}

5. Bitwise Operators:
   A5. Performing a bitwise AND operation between a and b:

int result = a & b;
Console.WriteLine(Convert.ToString(result, 2)); // Prints the result in binary format

6. Increment and Decrement Operators:
   A6. You can use the increment and decrement operators as follows:

int count = 5;
count++; // Increment by 1, count is now 6
count--; // Decrement by 1, count is now 5
count -= 2; // Decrement by 2, count is now 3

7. Conditional (Ternary) Operator:
   A7. You can use the conditional (ternary) operator to convert Celsius to Fahrenheit and print the result as follows:

int celsius = /_ Input from user _/;
double fahrenheit = celsius \* 9.0 / 5.0 + 32;
Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");

8. Null Coalescing Operator:
   A8. You can use the null coalescing operator to assign a default value to age if it is null:

int? age = /_ Input from user _/;
int defaultAge = age ?? 18;

9. String Concatenation Operator:
   A9. You can concatenate two strings using the + operator:

string firstName = /_ Input from user _/;
string lastName = /_ Input from user _/;
string fullName = firstName + " " + lastName;
Console.WriteLine("Full Name: " + fullName);

10. Relational Operators:

A10. You can use relational operators to check if the age is between 18 and 65:

csharp int age = /_ Input from user _/; if (age >= 18 && age <= 65) { Console.WriteLine("Valid age"); } else { Console.WriteLine("Invalid age"); }
