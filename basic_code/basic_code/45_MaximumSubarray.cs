/*
 * Program: Maximum Subarray Sum
 * 
 * Problem:
 * Find contiguous subarray with maximum sum
 * 
 * Example:
 * Input: [-2,1,-3,4,-1,2,1,-5,4]
 * Output: 6
 * 
 * Concept:
 * - Kadane’s Algorithm
 * 
 * Time Complexity: O(n)
 */

using System;

namespace basic_code
{
    internal class MaximumSubarray
    {
        internal void Find()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            int maxSum = nums[0];
            int current = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                current = Math.Max(nums[i], current + nums[i]);
                maxSum = Math.Max(maxSum, current);
            }

            Console.WriteLine("Max Sum: " + maxSum);
        }
    }
}