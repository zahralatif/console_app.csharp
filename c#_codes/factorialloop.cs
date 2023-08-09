using System;

namespace factorialloop
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"The factorial of {num} is {factorial}.");
            Console.ReadKey();
        }
    }

}