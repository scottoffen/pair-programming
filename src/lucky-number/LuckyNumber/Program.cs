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

            A number is considered lucky if:
                - it is at least six characters long
                - it contains *only* numeric characters (0-9)
                - the sum of the first half of the digits equals the sum of the second half of the digits.
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

        public static bool IsLucky(string number)
        {
            return false;
        }
    }
}
