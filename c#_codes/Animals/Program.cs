using System;

namespace polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Lion("Symba");
            Animal dolphin = new Dolphin("Flypper");
            Animal[] animals = new Animal[2];
            animals[0] = lion;
            animals[1] = dolphin;
            foreach (Animal a in animals)
            {
                a.MakeSound();
            }
            Console.WriteLine("----------------------------------------------------");
            if(dolphin is ISwim swimmer){
                swimmer.Swim();
            }

            Console.ReadKey();
        }
    }
}