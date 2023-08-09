using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int minValue = FindMin(numbers);
        int maxValue = FindMax(numbers);

        Console.WriteLine($"Minimum value: {minValue}");
        Console.WriteLine($"Maximum value: {maxValue}");
        Console.ReadKey();
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
