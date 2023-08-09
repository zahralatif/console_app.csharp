using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 9, 1, 7, 3 };
        
        int minValue = FindMin(numbers);
        int maxValue = FindMax(numbers);
        
        Console.WriteLine($"Minimum value: {minValue}");
        Console.WriteLine($"Maximum value: {maxValue}");
    }

    static int FindMin(int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static int FindMax(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}
