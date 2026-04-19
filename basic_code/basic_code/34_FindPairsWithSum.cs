/*
 * Program: Find All Pairs with a Given Sum
 * 
 * Problem:
 * Given an array of integers and a target value, find all pairs
 * of elements whose sum is equal to the target.
 * 
 * Example:
 * Input: arr = [2, 4, 3, 5, 6], target = 7
 * Output: (2,5), (4,3)
 * 
 * Concept:
 * - Use HashSet for O(n) solution
 * - For each element, check if (target - element) exists
 * - Avoid nested loops (O(n^2))
 * 
 * Time Complexity: O(n)
 */

using System;
using System.Collections.Generic;

namespace basic_code
{
    internal class FindPairsWithSum
    {
        internal void Find()
        {
            int[] arr = { 2, 4, 3, 5, 6 };
            int target = 7;

            HashSet<int> set = new HashSet<int>();

            foreach (int num in arr)
            {
                int complement = target - num;

                if (set.Contains(complement))
                {
                    Console.WriteLine($"({complement}, {num})");
                }

                set.Add(num);
            }
        }
    }
}