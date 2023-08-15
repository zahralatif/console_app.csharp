using System;

namespace primenums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lower number of the interval: ");
            int lowernum = int.Parse(Console.ReadLine());

            Console.Write("Enter the upper number of the interval: ");
            int uppernum = int.Parse(Console.ReadLine());

            Console.WriteLine($"Prime numbers between {lowernum} and {uppernum}: ");

            for (int num = lowernum; num <= uppernum; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ; ");
                }
            }

            Console.ReadKey();
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            else if (number == 2 || number == 3)
            {
                return true;
            }
            else if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }
            else
            {
                //the formula 6n ± 1
                for (int i = 5; i * i <= number; i += 6)
                {
                    if (number % i == 0 || number % (i + 2) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
