/*
 * Program: Container With Most Water
 * 
 * Problem:
 * Find two lines that hold maximum water
 * 
 * Example:
 * Input: [1,8,6,2,5,4,8,3,7]
 * Output: 49
 * 
 * Concept:
 * - Two Pointer Technique
 * - Move smaller height pointer
 * 
 * Time Complexity: O(n)
 */

using System;

namespace basic_code
{
    internal class ContainerWithMostWater
    {
        internal void Find()
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            int left = 0, right = height.Length - 1;
            int max = 0;

            while (left < right)
            {
                int area = Math.Min(height[left], height[right]) * (right - left);
                max = Math.Max(max, area);

                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            Console.WriteLine("Max Water: " + max);
        }
    }
}