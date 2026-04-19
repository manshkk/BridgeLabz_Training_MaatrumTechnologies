/*
 * Program: Merge Two Sorted Arrays
 * 
 * Problem:
 * Merge two sorted arrays into one sorted array.
 * 
 * Example:
 * Input: [1,3,5], [2,4,6]
 * Output: [1,2,3,4,5,6]
 * 
 * Concept:
 * - Two Pointer Technique
 * - Compare elements and merge
 * 
 * Time Complexity: O(n + m)
 */

using System;

namespace basic_code
{
    internal class MergeSortedArrays
    {
        internal void Merge()
        {
            int[] arr1 = { 1, 3, 5 };
            int[] arr2 = { 2, 4, 6 };

            int[] result = new int[arr1.Length + arr2.Length];

            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                    result[k++] = arr1[i++];
                else
                    result[k++] = arr2[j++];
            }

            while (i < arr1.Length)
                result[k++] = arr1[i++];

            while (j < arr2.Length)
                result[k++] = arr2[j++];

            Console.WriteLine(string.Join(", ", result));
        }
    }
}