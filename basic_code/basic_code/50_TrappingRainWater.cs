/*
 * Program: Trapping Rain Water
 * 
 * Problem:
 * Calculate water trapped between bars
 * 
 * Example:
 * Input: [0,1,0,2,1,0,1,3,2,1,2,1]
 * Output: 6
 * 
 * Concept:
 * - Two Pointer Technique
 * - Track left max and right max
 * 
 * Time Complexity: O(n)
 */

using System;

namespace basic_code
{
    internal class TrappingRainWater
    {
        internal void Calculate()   // MUST match Assignment
        {
            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            int left = 0, right = height.Length - 1;
            int leftMax = 0, rightMax = 0, water = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= leftMax)
                        leftMax = height[left];
                    else
                        water += leftMax - height[left];

                    left++;
                }
                else
                {
                    if (height[right] >= rightMax)
                        rightMax = height[right];
                    else
                        water += rightMax - height[right];

                    right--;
                }
            }

            Console.WriteLine("Water Trapped: " + water);
        }
    }
}