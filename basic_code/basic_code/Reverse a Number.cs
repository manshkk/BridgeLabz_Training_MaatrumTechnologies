/*
 * Program: Reverse a Number
 * 
 * Description:
 * This program reverses a given number.
 * 
 * Example:
 * Input: 1234
 * Output: 4321
 * 
 * Logic:
 * 1. Take input number N
 * 2. Initialize reverse = 0
 * 3. While N > 0:
 *      - Get remainder = N % 10
 *      - reverse = reverse * 10 + remainder
 *      - N = N / 10
 * 4. Print reverse
 */

using System;

namespace basic_code
{
    internal class ReverseNumber
    {
        internal void Reverse()
        {
            Console.Write("Enter a number: ");

            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            int reverse = 0;

            while (n != 0)
            {
                int remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n /= 10;
            }

            Console.WriteLine("Reversed number = " + reverse);
        }
    }
}
