using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace polimorphism
{
    internal class Lion : Animal
    {
        public Lion(string Name) : base (Name) {}
        public override void MakeSound()
        {
            Console.WriteLine("This is sound of Lion.");
        }
    }
}
