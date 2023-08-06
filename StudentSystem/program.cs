using System;

namespace studentsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            studentsystem zahra =  new studentsystem();
            zahra.SetID(1);
            zahra.SetName("Zahra");
            zahra.SetSurname("Latif");
            zahra.SetBirthdate(new DateTime(21 / 07 / 2005));
            zahra.Display();

            Console.ReadKey();
        }
    }
}