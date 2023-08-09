using System;

namespace MultiplyEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = MultiplyEven(n);
            Console.WriteLine($"The product of even numbers from 1 to {n} is {result}");
        }

        static int MultiplyEven(int n)
        {
            if (n <= 0)
            {
                return 1;
            }
            else if (n % 2 != 0)
            {
                return MultiplyEven(n - 1);
            }
            else
            {
                return n * MultiplyEven(n - 2);
            }
        }
    }

}