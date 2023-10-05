public int FindMaxValue(int[] numbers)
{
    int max = numbers[0];
    foreach (int num in numbers)
    {
        if (num > max)
        {
            max = num;
        }
    }
    return max;
}