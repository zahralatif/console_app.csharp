using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an expression to calculate:");
            string expression = Console.ReadLine();
            Console.WriteLine($"Result: {Calculate(expression)}");
        }

        static double Calculate(string expression)
        {
            string[] parts = expression.Split(' ');
            double num1 = double.Parse(parts[0]);
            string op = parts[1];
            double num2 = double.Parse(parts[2]);

            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine($"Invalid operator: {op}");
                    break;
            }

            return result;
        }
    }
}
