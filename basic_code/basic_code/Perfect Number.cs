/*
 * Program: Check whether a number is a Perfect Number
 * 
 * Description:
 * A Perfect Number is a number that is equal to the sum of its
 * positive divisors excluding itself.
 * 
 * Example:
 * Input: 28
 * Divisors: 1, 2, 4, 7, 14
 * Sum = 1 + 2 + 4 + 7 + 14 = 28
 * Output: Perfect Number
 * 
 * Logic:
 * 1. Take input N (N > 0)
 * 2. Initialize sum = 0
 * 3. Loop from i = 1 to N/2
 * 4. If N % i == 0 → add i to sum
 * 5. Compare sum with N
 *    - If equal → Perfect Number
 *    - Else → Not Perfect Number
 */

using System;

namespace basic_code
{
    internal class PerfectNumber
    {
        internal void CheckPerfect()
        {
            Console.Write("Enter a number: ");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            int sum = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine(n + " is a Perfect Number.");
            }
            else
            {
                Console.WriteLine(n + " is NOT a Perfect Number.");
            }
        }
    }
}