/*
 * Program: Substring Search
 */

using System;

namespace basic_code
{
    internal class SubstringSearch
    {
        internal void Search()
        {
            Console.Write("Enter main string: ");
            string main = Console.ReadLine() ?? "";

            Console.Write("Enter substring: ");
            string sub = Console.ReadLine() ?? "";

            Console.WriteLine(main.Contains(sub) ? "Found" : "Not Found");
        }
    }
}