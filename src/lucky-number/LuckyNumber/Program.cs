using System;
using System.Collections.Generic;

namespace LuckyNumber
{
    class Program
    {
        /*
            Lucky Number - Write a program that:
                - iterates over the values in the list
                - determines whether it is a lucky number
                - output to the console the number and the appropriate message
                    - "is lucky" if the number is lucky
                    - "is not lucky" if the number is not lucky

            Have the program run in an external console.

            A number is considered lucky if:
                - it is at least six characters long
                - it contains *only* numeric characters (0-9)
                - the sum of the first half of the digits equals the sum of the second half of the digits.

            Some sample code is provided as a possible starting point, feel
            free to use it or remove it.
        */

        private static List<string> numbers = new List<string>
        {
            "",
            "ab124c",
            "11111",
            "123456",
            "001100",
            "801522",
            "919642",
            "9935777",
            "2589634"
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Lucky Numbers!");

            // Your implementation here!

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        // Feel free to change the input parameter for your implementation
        public static bool IsLucky(object number)
        {
            return false;
        }
    }
}
