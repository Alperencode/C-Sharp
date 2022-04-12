using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class Person
    {
        public string Name;
        public string Surname;
        public int Age;

        public Person(string name,string surname,int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>() {"Alperen" , "John", "Jackie", "Jessie", "Alperen" };

            /*
             * List Methods 
             * 
             * Names.Remove("Alperen");  ----- Removes by using element value
             * Names.RemoveAt(0); ----- Removes by using index
             * Names.Insert(0,"Mike"); ----- Adds element to specific index
             * Names.Count ----- Returns the lenght of list
             * Names.IndexOf("Alperen"); ----- Return specific element's index number
             * Names.LastIndexOf("Alperen") ----- "Alperen" is more than one in this list it returns last index which has "Alperen" for value
             * Names.Contains("Alperen") ----- Returns boolean. If lists contains "Alperen" -> true, else -> false
             * Names.Sort() ----- Sorts the lists Alphabetically
             * Names.Reverse() ----- Sorts the list in reverse
             * Names.Clear() ----- Clears the list
             * String[] NameArray = Names.ToArray() ----- Converts list into array
             * 
            */

            List<Person> Persons = new List<Person>();
            Persons.Add(new Person("Alperen", "Ağa", 18));
            Persons.Add(new Person("Elon", "Musk", 50));
            Persons.Add(new Person("Mark", "Zuckerberg", 35));

            Console.WriteLine("Using For Loop");
            for (int i = 0; i < Names.Count; i++)
            {
                Console.WriteLine(Names[i]);
            }


            Console.WriteLine("\nUsing Foreach which is more effective");
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("");

            foreach (var person in Persons)
            {
                Console.WriteLine($"Name:{person.Name} Surname:{person.Surname} Age:{person.Age}");
            }
        }
    }
}
