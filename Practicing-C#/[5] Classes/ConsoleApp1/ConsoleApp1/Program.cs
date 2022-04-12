using System;

namespace ConsoleApp1
{

    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public static int Count;

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Count++;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello {Name + "" + Surname}!");
            Console.WriteLine($"Age: {Age}");

        }
    }

    class Pet
    {
        public static void Meow()
        {
            Console.WriteLine("Pet says Meow!");
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            // instance =   access the variable or method from an **object of a class**. (E.g.: person1.Name)
            // static =   access the variable or method from using the **class itself**. (E.g: Person.count)

            var person1 = new Person("Alperen","Ağa",18);
            person1.Introduce();
            Console.WriteLine($"Created person number is: {Person.Count}");

            Pet.Meow();
        }
    }
}
