using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            int numberOfGames;

            // Taking the input
            Console.WriteLine("How many games do you want to play");
            Console.Write("(Number of the games must be between 1 and 8): ");
            input = Console.ReadLine();

            // Converting string input to integer
            numberOfGames = Convert.ToInt32(input);

            // Bool we want to check
            bool numberControl = (numberOfGames <= 8) && (numberOfGames > 0);

            // if user is not passing the check
            if (!numberControl)
            {
                while (!numberControl)
                {
                    // re-taking the input until user passes the check
                    Console.Write("\nRe-enter a number between 1 and 8 for the number of games: ");
                    input = Console.ReadLine();
                    numberOfGames = Convert.ToInt32(input);
                    if ((numberOfGames <= 8) && (numberOfGames > 0))
                    {
                        // Breaking the while loop when user enters the correct number
                        break;
                    }
                }
            }

            // creating instance named "random" to use Random class
            Random random = new Random();
            
            // Game Function
            void Game(int gameNumber)
            {
                Console.WriteLine("");
                
                // defining odd and even counter
                int oddCounter = 0;
                int evenCounter = 0;

                // defining list for random numbers 
                List<int> Numbers = new List<int>();
                
                // generating 6 random numbers and adding them to Numbers list
                for(int i = 1; i <= 6; i++)
                {
                    Numbers.Add(random.Next(1, 50));
                }

                // Displaying the current game number
                Console.Write($"{gameNumber}. GAME:    ");

                // Displaying each number and checking if they are odd or even
                foreach (var number in Numbers)
                {    
                    Console.Write(number + "    ");
                    if (number % 2 == 0)
                    {
                        // means even
                        evenCounter++;
                    }else{

                        // means odd
                        oddCounter++;
                    }
                }

                // Displaying the Number of odds and evens
                Console.WriteLine();
                Console.WriteLine("Number of odds: " + oddCounter);
                Console.WriteLine("Number of evens: " + evenCounter);

            }

            // For loop to generate games
            for (int gameNumber = 1; gameNumber <= numberOfGames; gameNumber++)
            {
                Game(gameNumber);
            }

            // Console.Readline() to avoid instant exit
            Console.ReadLine();
        }
    }
}
