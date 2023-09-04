using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            // Create two Lists of type int.
            
            // Name one List "evens"
            List<int> evens = new();
          
            //Name the other List "odds"
            List<int> odds = new(); 

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (var i in array) 
            {

                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }


            }


            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            Console.WriteLine("Good day, I have ten numbers on display. Which ones are you interested in seeing?");
            Console.WriteLine("");

            Console.WriteLine("1 - Odd numbers.");
            Console.WriteLine("2 - Even numbers.");
            Console.WriteLine("Any other key - Decline");
            

            bool validInput = int.TryParse(Console.ReadLine(), out int myChoice);

            while (!validInput || myChoice > 2 || myChoice <= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Have a good day!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            
            if (myChoice == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Certainly! Here are all the odd numbers:");
                Console.WriteLine("");
                
                foreach (var i in odds)
                {
                    Console.WriteLine($"{i}");
                }

                Console.WriteLine("");
                Console.WriteLine("Have a good day!");
            }
            else 
            {
                Console.WriteLine("");
                Console.WriteLine("Certainly! Here are all the even numbers:");
                Console.WriteLine("");

                foreach (var i in evens)
                {
                    Console.WriteLine($"{i}");
                }

                Console.WriteLine("");
                Console.WriteLine("Have a good day!");
            }

        }
    }
}
