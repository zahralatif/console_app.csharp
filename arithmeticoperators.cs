using System;

class Program
{
    static void Main()
    {
        int a = 6, b = 5, c = 4, d = 3, e = 2;

        int result = a-- * --b + e++ / c - ++d / a * b++ - --e * c;
        // result = 6 (a = 5) * 4 + 2 (e = 3) / 4 - 4 / 5 * 4 (b = 5) - 2 * 4
        Console.WriteLine("Initial values: a= {0}, b= {1}, c= {2}, d= {3}, e= {4}", a, b, c, d, e);
        // a=5 b=5 c=4 d=4 e=2
        Console.WriteLine($"\nresult = a-- * --b + e++ / c - ++d / a * b++ - --e * c;");
        Console.WriteLine("\nExpression Result: {0}", result);
        // 6 * 4 + 2 / 4 - 4 / 5 * 4 - 2 * 4 = 24 + 0 - 4 / 20 - 8 = 16
        Console.ReadLine();
    }
}