using System;

namespace Conversion
{
    class conversion
    {
        static void Main(string[] args)
        {
            int numInt = 21;
            double numDouble = (double)numInt;
            Console.WriteLine("Int to Double Conversion: {0} => {1}", numInt, numDouble);

            float numFloat = 21.7f;
            int numInt2 = (int)numFloat;
            Console.WriteLine("Float to Int Conversion: {0} => {1}", numFloat, numInt2);

            string strInt = "7";
            int numInt3 = int.Parse(strInt);
            Console.WriteLine("String to Int Conversion: {0} => {1}", strInt, numInt3);

            bool boolVar = true;
            string strBool = boolVar.ToString();
            Console.WriteLine("Bool to String Conversion: {0} => {1}", boolVar, strBool);

            double numDouble2 = 7.21;
            string strDouble = numDouble2.ToString();
            Console.WriteLine("Double to String Conversion: {0} => {1}", numDouble2, strDouble);


            Console.ReadKey();

        }
    }
}
