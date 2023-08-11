using System;

namespace AverageOfArray
{
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

            double average = CalculateAverage(numbers);

            Console.WriteLine($"The average is: {average}");
            Console.ReadKey();
        }

        static double CalculateAverage(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            double average = (double)sum / array.Length;
            return average;
        }
    }
}
