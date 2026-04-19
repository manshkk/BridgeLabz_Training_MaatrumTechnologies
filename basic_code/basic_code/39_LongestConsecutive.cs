/*
 * Program: Longest Consecutive Subsequence
 * 
 * Problem:
 * Find longest sequence of consecutive numbers.
 * 
 * Example:
 * Input: [100,4,200,1,3,2]
 * Output: 4 (1,2,3,4)
 * 
 * Concept:
 * - Use HashSet
 * - Start only from sequence beginning
 * 
 * Time Complexity: O(n)
 */

using System;
using System.Collections.Generic;

namespace basic_code
{
    internal class LongestConsecutive
    {
        internal void Find()
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            HashSet<int> set = new HashSet<int>(nums);

            int longest = 0;

            foreach (int num in set)
            {
                if (!set.Contains(num - 1))
                {
                    int current = num;
                    int streak = 1;

                    while (set.Contains(current + 1))
                    {
                        current++;
                        streak++;
                    }

                    longest = Math.Max(longest, streak);
                }
            }

            Console.WriteLine("Longest: " + longest);
        }
    }
}