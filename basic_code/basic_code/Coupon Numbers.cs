/*
 * Program: Coupon Numbers
 * 
 * Description:
 * Given N distinct coupon numbers, this program generates random numbers
 * until all distinct coupons are collected.
 * 
 * Input: N (number of distinct coupons)
 * Output: Total random numbers generated to collect all coupons
 * 
 * Logic:
 * 1. Take input N
 * 2. Create a boolean array of size N to track collected coupons
 * 3. Initialize count = 0 and distinct = 0
 * 4. Generate random number between 0 and N-1
 * 5. If coupon not already collected:
 *      - Mark it as collected
 *      - Increase distinct count
 * 6. Repeat until all coupons are collected
 * 7. Print total random numbers generated
 * 
 * Functions:
 * - GenerateRandom(): generates random coupon number
 * - CollectCoupons(): processes distinct coupons
 */

using System;

namespace basic_code
{
    internal class CouponNumbers
    {
        static Random random = new Random();

        // Function to generate random number
        static int GenerateRandom(int n)
        {
            return random.Next(0, n);
        }

        internal void CollectCoupons()
        {
            Console.Write("Enter number of distinct coupons: ");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            bool[] collected = new bool[n];
            int distinct = 0;
            int totalRandomNumbers = 0;

            while (distinct < n)
            {
                int coupon = GenerateRandom(n);
                totalRandomNumbers++;

                if (!collected[coupon])
                {
                    collected[coupon] = true;
                    distinct++;
                }
            }

            Console.WriteLine("Total random numbers needed: " + totalRandomNumbers);
        }
    }
}
