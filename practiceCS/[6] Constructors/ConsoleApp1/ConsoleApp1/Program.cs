using System;

namespace ConsoleApp1
{
    class Person
    {
        private string Name;
        private string Surname;
        private int Age;
        // Constructor 
        // code snipper is 'ctor'
 
        // Default constructor
        public Person()
        {}
        // Constructor Overloading
        // Is making more than one initalizion
        // Usage incase: in some case we dont know if all the variables defined or have some value
        // :    this = is used for initalize this('Constructor variables') constructor before initilaze that constructor
        
        public Person(string name)
        :   this()
        {
            this.Name = name;
        }
        public Person(string name, string surname)
        :   this(name)
        {
            this.Surname = surname;
        }

        public Person(string name,string surname, int age)
        :   this(name, surname)
        {
            this.Age = age;
        }

    }
}
