using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphism
{
    internal class Dolphin : Animal, ISwim
    {
        public Dolphin(string Name) : base(Name) { }
        public override void MakeSound()
        {
            Console.WriteLine("This is sound of Dolphin.");
        }
        public void Swim()
        {
            Console.WriteLine("Dolphin swims gratefully.");
        }
    }
}