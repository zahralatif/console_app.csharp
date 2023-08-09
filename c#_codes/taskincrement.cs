using System;

namespace taskincrement
{
    class taskincrement
    {
        static void Main(string[] args)
        {
            int x = 24;
            int y = 13;

            int z = (x + y) / 2 + y++ + ++y + 2 * (x-- * 4);
            //z => (x + y) / 2 = (24 + 13) / 2 = 37 / 2 = 18 
            //x = 24 y = 13 z = 18 + ... 
            //z => y++ = 13 (next time y = 14) = 18 + 13 = 31
            //x = 24 y = 14 z = 31 + ... 
            //z => ++y => 14 + 1 = 15 => 31 + 15 = 46
            //x = 24 y = 15 z = 46 + ... 
            //z => 2 * (x-- * 4) = 2 * 24 * 4 = 2 * 96 = 192 => 46 + 192 = 238 (next time x = 23) 
            //x = 23 y = 15 z = 238
            int w = z++ + (w = y) - --w;
            //w = 238 (next time z = 239) + 15 - 14 = 239
            //x = 23 y = 15 z = 239 w = 239
            Console.WriteLine("x = {0}; y = {1}; z = {2}; w = {3}",x,y,z,w);
            Console.ReadLine();

        }
    }
}