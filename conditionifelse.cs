using System;

class conditionals
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) {
            Console.WriteLine("The number {0} is positive.", num);
        }
        else if (num < 0) {
            Console.WriteLine("The number {0} is negative.", num);
        }
        else { 
            Console.WriteLine("The number {0} is neither positive nor negative.", num);
        }
            Console.ReadLine();

    }
}