/*
 * Program: Move All Zeros to End
 * 
 * Problem:
 * Move all zero elements to the end while maintaining
 * the order of non-zero elements.
 * 
 * Example:
 * Input: [0,1,0,3,12]
 * Output: [1,3,12,0,0]
 * 
 * Concept:
 * - Two-pointer technique
 * - First fill non-zero elements
 * - Then fill remaining with zeros
 * 
 * Time Complexity: O(n)
 */

using System;

namespace basic_code
{
    internal class MoveZeros
    {
        internal void Move()
        {
            int[] arr = { 0, 1, 0, 3, 12 };
            int index = 0;

            foreach (int num in arr)
            {
                if (num != 0)
                    arr[index++] = num;
            }

            while (index < arr.Length)
                arr[index++] = 0;

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}