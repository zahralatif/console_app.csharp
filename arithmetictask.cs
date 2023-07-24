using System;

class Program
{
    static void Main()
    {
        int a = 3, b = 5, c = 7, d = 2, e = 4;

        int result = a++ + --b * c - e-- + ++d / a + b-- * c / e;
        // result = 3 (a = 4) + 4 * 7 - 4 (e = 3) + 3 / 4 + 4 (b = 3) * 7 / 3
        Console.WriteLine("Initial values: a= {0}, b= {1}, c= {2}, d= {3}, e= {4}", a,b,c,d,e);
        // a = 4 b = 3 c = 7 d = 3 e = 3
        Console.WriteLine($"\nresult = a++ + --b * c - e-- + ++d / a + b-- * c / e");
        Console.WriteLine("\nExpression Result: {0}",result);
        // 3 + 4 * 7 - 4 + 3 / 4 + 4 * 7 / 3 = 3 + 28 - 4 + 0 + 28 / 3 = 27 + 9 = 36
        Console.ReadLine();
    }
}