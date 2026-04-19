/*
 * Program: Sort Array of 0s, 1s, and 2s
 * 
 * Problem:
 * Sort array containing only 0, 1, 2 without using extra space
 * 
 * Example:
 * Input: [2,0,1]
 * Output: [0,1,2]
 * 
 * Concept:
 * - Dutch National Flag Algorithm
 * - 3 pointers: low, mid, high
 * 
 * Time Complexity: O(n)
 */

using System;

namespace basic_code
{
    internal class Sort012
    {
        internal void Sort()
        {
            int[] arr = { 2, 0, 1 };

            int low = 0, mid = 0, high = arr.Length - 1;

            while (mid <= high)
            {
                if (arr[mid] == 0)
                {
                    (arr[low], arr[mid]) = (arr[mid], arr[low]);
                    low++; mid++;
                }
                else if (arr[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    (arr[mid], arr[high]) = (arr[high], arr[mid]);
                    high--;
                }
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}