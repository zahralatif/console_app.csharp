using System;

namespace reversefunction
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter any text: ");
            string userInput = Console.ReadLine();
            Console.Write("Your reverse text: ");
            string reversed = Reverse(userInput);
            Console.WriteLine(reversed);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

}