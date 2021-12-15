using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Languages = { "Python", "C++", "Java", "Php", "Swift", "C#" };   // pre-defined array
            string[] Animals = new string[4];   // Create a empty array but we need to specify the lenght of array
            /*
             * Array Methods
             * 
             * Languages.Lenght ----- Returns the lenght of array
             * Array.IndexOf(Languages, "Java") ----- Returns the specific element's index
             * Array.Exists(Languages, language => language.Contains("C") ----- Returns the boolean value depending if any element contains "C"
             * Array.Find(Languages, language => language.Contains("C") ----- Returns the first element that passes the condition
             * Array.FindLast(Languages, language => language.Contains("C") ----- Returns the last element that passes the condition
             * Array.FindIndex(Languages, language => language.Contains("C")); ----- Return the first element's index that passes the condition
             * Array.FindAll(Languages, language => language.Contains("C")) ----- Returns an array that contains the condition
             * Array.Reverse(Languages) ----- Reverse the array
            */

            Console.WriteLine("Write a animal name:");

            for (int i = 0; i < Animals.Length; i++)
            {
                Animals[i] = Console.ReadLine();
            }

            foreach (var animal in Animals)
            {
                Console.WriteLine($"Animal name: {animal}");
            }

            var check = Array.Exists(Languages, language => language.Contains("C"));
            Console.WriteLine(check);

            var index = Array.FindIndex(Languages, language => language.Contains("C"));
            Console.WriteLine(index);       
        }
    }
}
