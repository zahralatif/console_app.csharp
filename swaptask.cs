using System;

namespace SwappingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, swapnum;
            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before swapping first number = {num1} and second number = {num2}");

            swapnum = num1;
            num1 = num2;
            num2 = swapnum;

            Console.WriteLine($"After swapping first number = {num1} and second number = {num2}");
            Console.ReadKey();
        }
    }
}