using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string:");
            string str = Console.ReadLine();
            Console.WriteLine($"1. Uppercase: {str.ToUpper()}");
            Console.WriteLine($"2. Lowercase: {str.ToLower()}");
            Console.WriteLine($"3. Total characters: {str.Length}");
            Console.WriteLine($"4. First 5 characters: {str.Substring(0, 5)}");

            if (str.Length >= 5)
            {
                Console.WriteLine($"5. Last 5 characters: {str.Substring(str.Length - 5)}");
            }
            else
            {
                Console.WriteLine($"5. Last 5 characters: {str}");
            }

            Console.WriteLine($"6. Replace 'a' with '*': {str.Replace('a', '*')}");
            Console.WriteLine($"7. Contains 'CSharp': {str.Contains("CSharp")}");
            Console.WriteLine($"8. Index of 'e': {str.IndexOf('e')}");

            string[] words = str.Split(' '); 
            Console.WriteLine($"9. Split words:");
            foreach (string word in words)
            {
                Console.WriteLine($"- {word}");
            }

            Console.ReadKey();
        }
    }
}
