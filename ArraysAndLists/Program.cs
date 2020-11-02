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
            var arr = new int[10];
            for (int i = 1; i <= 10; i++)
            {
                arr[i - 1] = i;
            }
            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i = 0; i < arr.Length; i++)        
            {
                if (arr[i] % 2 == 0)
                {
                    evens.Add(arr[i]);
                } 
                else
                {
                    odds.Add(arr[i]);
                }
            }

            /* Now using foeach or for loops,
            * display each List of even and odd numbers
            *
            * Try to be creative in your display
            */
            Console.WriteLine("===========================");
            Console.WriteLine("Odd numbers are: ");
            foreach (var num in odds)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("===========================");
            Console.WriteLine("Even numbers are: ");
            foreach (var num in evens)
            {
                Console.WriteLine(num);
            }
   
        }
    }
}
