/*
 * Program: Longest Substring Without Repeating Characters
 */

using System;
using System.Collections.Generic;

namespace basic_code
{
    internal class LongestSubstring
    {
        internal void Find()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine() ?? "";

            int max = 0;
            var set = new HashSet<char>();
            int left = 0;

            for (int right = 0; right < str.Length; right++)
            {
                while (set.Contains(str[right]))
                {
                    set.Remove(str[left]);
                    left++;
                }

                set.Add(str[right]);
                max = Math.Max(max, right - left + 1);
            }

            Console.WriteLine("Length: " + max);
        }
    }
}