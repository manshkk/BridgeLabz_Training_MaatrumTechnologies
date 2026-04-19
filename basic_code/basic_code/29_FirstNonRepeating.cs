/*
 * Program: First Non-Repeating Character
 */

using System;
using System.Linq;

namespace basic_code
{
    internal class FirstNonRepeating
    {
        internal void Find()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine() ?? "";

            var result = str.GroupBy(c => c)
                            .Where(g => g.Count() == 1)
                            .Select(g => g.Key)
                            .FirstOrDefault();

            Console.WriteLine(result == default ? "None" : result.ToString());
        }
    }
}