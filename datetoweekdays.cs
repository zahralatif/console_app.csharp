using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a date (dd-mm-yyyy): ");
        string input = Console.ReadLine();
        DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", null);
        string weekday = date.ToString("dddd");
        Console.WriteLine($"The weekday of {input} is {weekday}");
        Console.ReadKey();

    }
}
