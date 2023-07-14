using System;

namespace average
{
    class average
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the score for subject 1: ");
            int score1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the score for subject 2: ");
            int score2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the score for subject 3: ");
            int score3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The average grade is:");
            Console.WriteLine(CalculateAverage(score1,score2,score3));

            Console.ReadKey();
        }
        static double CalculateAverage(int score1,int score2, int score3)
        {
            return ((score1+score2+score3)/3);
        }
    }
}