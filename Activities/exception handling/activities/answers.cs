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