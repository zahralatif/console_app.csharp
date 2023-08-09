using System;

namespace multidimensionalarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine(numbers[2, 2]);
        }
    }
}