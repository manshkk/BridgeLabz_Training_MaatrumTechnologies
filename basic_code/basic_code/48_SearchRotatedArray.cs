/*
 * Program: Search in Rotated Sorted Array
 * 
 * Problem:
 * Search element in rotated sorted array
 * 
 * Example:
 * Input: [4,5,6,7,0,1,2], target=0
 * Output: index 4
 * 
 * Concept:
 * - Modified Binary Search
 * 
 * Time Complexity: O(log n)
 */

using System;

namespace basic_code
{
    internal class SearchRotatedArray
    {
        internal void Search()
        {
            int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;

            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                {
                    Console.WriteLine("Found at index: " + mid);
                    return;
                }

                if (arr[left] <= arr[mid])
                {
                    if (target >= arr[left] && target < arr[mid])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                else
                {
                    if (target > arr[mid] && target <= arr[right])
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
            }

            Console.WriteLine("Not Found");
        }
    }
}