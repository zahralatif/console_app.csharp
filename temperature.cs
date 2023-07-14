using System;

namespace task120723
{
    class average
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.Write("The temperature in Fahrenheit is: ");
            Console.WriteLine(CalculateFahrenheit(celsius));

            Console.ReadKey();
        }

        static int CalculateFahrenheit(int celsius)
        {
            return (celsius * 9 / 5 + 32);
        }
    }
}
