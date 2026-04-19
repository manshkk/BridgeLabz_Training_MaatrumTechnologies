/*
 * Program: Intersection of Two Arrays
 * 
 * Problem:
 * Find common elements between two arrays.
 * 
 * Example:
 * Input: [1,2,2,1], [2,2]
 * Output: [2,2]
 * 
 * Concept:
 * - Use Dictionary to store frequency
 * - Match elements from second array
 * 
 * Time Complexity: O(n)
 */

using System;
using System.Collections.Generic;

namespace basic_code
{
    internal class ArrayIntersection
    {
        internal void Find()
        {
            int[] arr1 = { 1, 2, 2, 1 };
            int[] arr2 = { 2, 2 };

            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (int num in arr1)
            {
                if (!map.ContainsKey(num)) map[num] = 0;
                map[num]++;
            }

            foreach (int num in arr2)
            {
                if (map.ContainsKey(num) && map[num] > 0)
                {
                    Console.Write(num + " ");
                    map[num]--;
                }
            }
        }
    }
}