using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Types
            string hello = "Hello World!";
            int number = 15;
            float pi = 3.14f;
            double long_pi = 3.14159265359;
            bool isTrue = true;

            // Lists
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; // [Fixed] Cannot be changed
            List<int> intList = new List<int>() { 10, 20, 30, 40 };

            // Functions
            int SumNumbers(int x, int y)
            {
                return x + y;
            }

            bool CheckTrue(bool x)
            {
                if (x){
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }
    }
}
