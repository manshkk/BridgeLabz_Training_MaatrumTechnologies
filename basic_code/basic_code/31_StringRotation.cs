/*
 * Program: String Rotation Check
 */

using System;

namespace basic_code
{
    internal class StringRotation
    {
        internal void Check()
        {
            Console.Write("Enter first string: ");
            string s1 = Console.ReadLine() ?? "";

            Console.Write("Enter second string: ");
            string s2 = Console.ReadLine() ?? "";

            bool result = s1.Length == s2.Length && (s1 + s1).Contains(s2);

            Console.WriteLine(result ? "Rotation" : "Not Rotation");
        }
    }
}