using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsystem
{
    internal class studentsystem
    {
        private string Name;
        private string Surname;
        private DateTime Birthdate;
        private int Id;

        public void SetName(string name)
        { this.Name = name; }
        public string GetName() { return this.Name; }   
        public void SetSurname(string surname)
        { this.Surname = surname; }
        public string GetSurname() { return this.Surname; }
        public void SetBirthdate(DateTime birthdate)
        { this.Birthdate = birthdate;}
        public DateTime GetBirthdate() { return this.Birthdate; }
        public void SetID(int ID)
        { this.Id = ID; }
        public int GetID() { return this.Id; }
        public void Display()
        {
            Console.WriteLine($"{Id}. {Name} {Surname} - {Birthdate}");
        }
    }
}
