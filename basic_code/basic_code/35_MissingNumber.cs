/*
 * Program: Find Missing Number in an Array
 * 
 * Problem:
 * Given an array of size n-1 containing numbers from 1 to n,
 * find the missing number.
 * 
 * Example:
 * Input: [1, 2, 4, 5, 6]
 * Output: 3
 * 
 * Concept:
 * - Use mathematical formula: n*(n+1)/2
 * - Subtract actual sum from expected sum
 * 
 * Time Complexity: O(n)
 */

using System;

namespace basic_code
{
    internal class MissingNumber
    {
        internal void Find()
        {
            int[] arr = { 1, 2, 4, 5, 6 };
            int n = arr.Length + 1;

            int total = n * (n + 1) / 2;
            int sum = 0;

            foreach (int num in arr)
                sum += num;

            Console.WriteLine("Missing Number: " + (total - sum));
        }
    }
}