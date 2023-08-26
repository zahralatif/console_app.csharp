using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphism
{
    internal class Animal
    {
        public string Name { get; set; }
        public Animal(string Name)
        {
            this.Name = Name;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("The Animal makes a generic sound");
        }
    }
}
