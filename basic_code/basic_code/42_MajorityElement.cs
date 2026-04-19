/*
 * Program: Find Majority Element
 * 
 * Problem:
 * Find element appearing more than n/2 times.
 * 
 * Concept:
 * - Moore’s Voting Algorithm
 * - Keep candidate and count
 * 
 * Time Complexity: O(n)
 */

using System;

namespace basic_code
{
    internal class MajorityElement
    {
        internal void Find()
        {
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };

            int count = 0, candidate = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                    candidate = num;

                count += (num == candidate) ? 1 : -1;
            }

            Console.WriteLine("Majority Element: " + candidate);
        }
    }
}