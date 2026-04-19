/*
 * Program: Find Peak Element
 * 
 * Problem:
 * Find element greater than neighbors
 * 
 * Example:
 * Input: [1,2,3,1]
 * Output: 3
 * 
 * Concept:
 * - Binary Search
 * 
 * Time Complexity: O(log n)
 */

using System;

namespace basic_code
{
    internal class FindPeakElement
    {
        internal void Find()
        {
            int[] nums = { 1, 2, 3, 1 };

            int left = 0, right = nums.Length - 1;

            while (left < right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] > nums[mid + 1])
                    right = mid;
                else
                    left = mid + 1;
            }

            Console.WriteLine("Peak Element: " + nums[left]);
        }
    }
}