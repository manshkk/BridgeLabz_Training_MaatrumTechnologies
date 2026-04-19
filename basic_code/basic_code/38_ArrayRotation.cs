/*
 * Program: Rotate Array by K Positions
 * 
 * Problem:
 * Rotate an array to the right by k steps.
 * 
 * Example:
 * Input: [1,2,3,4,5], k=2
 * Output: [4,5,1,2,3]
 * 
 * Concept:
 * - Reverse whole array
 * - Reverse first k elements
 * - Reverse remaining elements
 * 
 * Time Complexity: O(n)
 */

using System;

namespace basic_code
{
    internal class ArrayRotation
    {
        internal void Rotate()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = 2;

            int n = arr.Length;
            k = k % n;

            Array.Reverse(arr);
            Array.Reverse(arr, 0, k);
            Array.Reverse(arr, k, n - k);

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}