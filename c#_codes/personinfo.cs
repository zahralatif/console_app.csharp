using System;

namespace personinfo
{
    enum Gender
    {
        Male,
        Female,
        Other
    }

    class Person
    {
        private string name;
        private int age;
        private Gender gender; //* Using the enum for gender

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
        
        public void setGender(Gender Gender)
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
        
        public Gender getGender()
        {
            return gender;
        }

        static void Main(string[] args)
        {
            Person person = new Person();

            person.setName("Zahra");
            person.setAge(18);
            person.setGender(Gender.Female);
            Console.WriteLine($"Personal information: {person.getName()}, {person.getAge()}, {person.getGender()} ");
            Console.ReadKey();
        }
    }
}
