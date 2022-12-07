using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public static void HelloMessage(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        public static void SumNumbers(int x, int y) => Console.WriteLine($"Sum of the number is {x + y}");

    }
}
