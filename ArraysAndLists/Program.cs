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

            var intArray = new int[10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Create two Lists of type int
            // Name one List "evens"

            var evenList = new List<int>();

            // Name the other List "odds"

            var oddList = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            for (int i=0; i <= intArray.Length -1; i++)
            {
                if (intArray[i] % 2 == 1)
                {
                    oddList.Add(intArray[i]);
                }
                else
                {
                    evenList.Add(intArray[i]);
                }
                    
            }


            //Console.WriteLine(evenList);
            //Console.WriteLine(oddList);
            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            string evenString = "Even numbers: \n";
            string oddString = "Odd numbers: \n";
            foreach (var i in evenList)
            {
                evenString += $" {i} ";
            }
            foreach (var j in oddList)
            {
                oddString += $" {j} ";
             }

            Console.WriteLine(evenString);
            Console.WriteLine(oddString);
            {
               
            }
        }
    }
}
