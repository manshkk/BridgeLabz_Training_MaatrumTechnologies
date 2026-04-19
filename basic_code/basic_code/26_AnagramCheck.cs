/*
 * Program: Anagram Check
 */

using System;
using System.Linq;

namespace basic_code
{
    internal class AnagramCheck
    {
        internal void Check()
        {
            Console.Write("Enter first string: ");
            string s1 = Console.ReadLine() ?? "";

            Console.Write("Enter second string: ");
            string s2 = Console.ReadLine() ?? "";

            var a = s1.ToLower().OrderBy(c => c);
            var b = s2.ToLower().OrderBy(c => c);

            Console.WriteLine(a.SequenceEqual(b) ? "Anagram" : "Not Anagram");
        }
    }
}