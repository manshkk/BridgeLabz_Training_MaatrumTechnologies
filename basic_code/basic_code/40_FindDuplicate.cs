/*
 * Program: Find Duplicate Number
 * 
 * Problem:
 * Find duplicate in array of n+1 integers (1 to n).
 * 
 * Example:
 * Input: [1,3,4,2,2]
 * Output: 2
 * 
 * Concept:
 * - Sort array and compare adjacent elements
 * - Can also use cycle detection (advanced)
 * 
 * Time Complexity: O(n log n)
 */

using System;

namespace basic_code
{
    internal class FindDuplicate
    {
        internal void Find()
        {
            int[] arr = { 1, 3, 4, 2, 2 };

            Array.Sort(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    Console.WriteLine("Duplicate: " + arr[i]);
                    return;
                }
            }
        }
    }
}