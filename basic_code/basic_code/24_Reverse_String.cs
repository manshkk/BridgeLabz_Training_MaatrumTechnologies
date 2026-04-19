/*
 * Program: Reverse a String
 * 
 * Logic:
 * 1. Take string input
 * 2. Convert to char array
 * 3. Reverse and print
 */

using System;

namespace basic_code
{
    internal class ReverseString
    {
        internal void Reverse()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine() ?? "";

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);

            Console.WriteLine("Reversed: " + new string(arr));
        }
    }
}