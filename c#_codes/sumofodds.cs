using System;

namespace task
    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num= Convert.ToInt32(Console.ReadLine());
            int sum = 0;
                for (int i = 1; i < num; i += 2)
                {
                    sum += i;
                }
            Console.WriteLine($"Sum of odd numbers to {num}: {sum}");
            Console.ReadKey();  
        }
    }
}