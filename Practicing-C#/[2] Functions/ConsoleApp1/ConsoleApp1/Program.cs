using System;

namespace ConsoleApp1
{
    class Program
    {
        // private = cannot accessible for other functions
        // public = accessible for every function
        // static = means that function belongs to that specific class

        static void Main(string[] args)
        {
            Class1.HelloMessage("Alperen");
            Class1.SumNumbers(10, 25);
        }
    }
}
