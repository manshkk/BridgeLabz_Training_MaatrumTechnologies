/*
 * Program: Check Palindrome String
 * 
 * Logic:
 * 1. Take string input
 * 2. Reverse the string
 * 3. Compare original and reversed
 */

using System;
using System.Linq;

namespace basic_code
{
    internal class PalindromeString
    {
        internal void Check()
        {
            Console.Write("Enter string: ");
            string str = (Console.ReadLine() ?? "").ToLower();

            string rev = new string(str.Reverse().ToArray());

            if (str == rev)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}