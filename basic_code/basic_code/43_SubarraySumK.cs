/*
 * Program: Subarray Sum Equals K
 * 
 * Problem:
 * Count number of subarrays whose sum equals k
 * 
 * Example:
 * Input: [1,1,1], k=2 → Output: 2
 * 
 * Concept:
 * - Prefix Sum + HashMap
 * 
 * Time Complexity: O(n)
 */

using System;
using System.Collections.Generic;

namespace basic_code
{
    internal class SubarraySumK
    {
        internal void Find()
        {
            int[] nums = { 1, 1, 1 };
            int k = 2;

            Dictionary<int, int> map = new Dictionary<int, int>();
            map[0] = 1;

            int sum = 0, count = 0;

            foreach (int num in nums)
            {
                sum += num;

                if (map.ContainsKey(sum - k))
                    count += map[sum - k];

                if (!map.ContainsKey(sum))
                    map[sum] = 0;

                map[sum]++;
            }

            Console.WriteLine("Count: " + count);
        }
    }
}