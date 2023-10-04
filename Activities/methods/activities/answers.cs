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