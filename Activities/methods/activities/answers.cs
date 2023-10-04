//1

public int CalculateFactorial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * CalculateFactorial(n - 1);
    }
}

//2 Method Overloading:
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    // Implement similar methods for subtraction, multiplication, and division.
}

//3 Method Overriding:
public class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }
}

//4 Static Methods:
public class MathUtility
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0)
            return 0;

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return (double)sum / numbers.Length;
    }
}

//5 Extension Methods:
public static class StringExtensions
{
    public static int WordCount(this string input)
    {
        // Split the input string into words and count them.
        return input.Split(new[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}

// Usage:
string sentence = "This is a sample sentence.";
int wordCount = sentence.WordCount();

//6 Optional Parameters:
public void Greet(string name, string greeting = "Hello")
{
    Console.WriteLine($"{greeting}, {name}!");
}

//7 Named Parameters:
public void Greet(string name, string greeting = "Hello")
{
    Console.WriteLine($"{greeting}, {name}!");
}

// Usage:
Greet(name: "Alice", greeting: "Hi");

// 8 Async Methods:
public async Task GetDataAsync()
{
    await Task.Delay(2000); // Simulate a delay of 2 seconds.
    Console.WriteLine("Data fetched asynchronously.");
}

// Usage:
await GetDataAsync();

// 9 Lambda Expressions:
public List<int> FilterEvenNumbers(List<int> numbers)
{
    return numbers.Where(num => num % 2 == 0).ToList();
}

//10 Delegate as a Method Parameter:
public delegate double MathOperation(List<int> numbers);

public double Sum(List<int> numbers)
{
    return numbers.Sum();
}

public double Product(List<int> numbers)
{
    double result = 1;
    foreach (int num in numbers)
    {
        result *= num;
    }
    return result;
}

public double Average(List<int> numbers)
{
    return numbers.Average();
}

// Usage:
MathOperation operation = Sum;
double result = operation(numbers);