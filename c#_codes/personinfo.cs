using System;

namespace personinfo
{
    class Person
    {
        private string name;
        private int age;
        private string gender;

        public Person()
        {
            Console.WriteLine("Personal information creating...");
        }
        public void setName(string Name)
        {
            name = Name;
        }
        public void setAge(int Age)
        {
            age = Age;
        }
        public void setGender(string Gender)
        {
            gender = Gender;
        }
        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public string getGender()
        {
            return gender;
        }

        static void Main(string[] args)
        {
            Person person = new Person();

            person.setName("Zahra");
            person.setAge(18);
            person.setGender("female");
            Console.WriteLine($"Personal information: {person.getName()}, {person.getAge()}, {person.getGender()} ");
            Console.ReadKey();
        }

    }
}