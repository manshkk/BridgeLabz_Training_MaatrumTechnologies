/*
 * Program: Product of Array Except Self
 * 
 * Problem:
 * Return array where each element is product of all except itself
 * 
 * Example:
 * Input: [1,2,3,4]
 * Output: [24,12,8,6]
 * 
 * Concept:
 * - Prefix product + Suffix product
 * - No division used
 * 
 * Time Complexity: O(n)
 */

using System;

namespace basic_code
{
    internal class ProductExceptSelf
    {
        internal void Calculate()
        {
            int[] nums = { 1, 2, 3, 4 };
            int n = nums.Length;

            int[] result = new int[n];

            int prefix = 1;
            for (int i = 0; i < n; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            int suffix = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] *= suffix;
                suffix *= nums[i];
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}