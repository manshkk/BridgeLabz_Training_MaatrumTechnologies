/*
 * Program: Check whether a number is a Prime Number
 * 
 * Description:
 * A Prime Number is a number greater than 1 that is divisible
 * only by 1 and itself.
 * 
 * Example:
 * Input: 7
 * Output: Prime Number
 * 
 * Input: 8
 * Output: Not a Prime Number
 * 
 * Logic:
 * 1. Take input N
 * 2. If N <= 1 → Not Prime
 * 3. Loop from i = 2 to √N
 * 4. If N % i == 0 → Not Prime
 * 5. Else → Prime
 */

using System;

namespace basic_code
{
    internal class PrimeNumber
    {
        internal void CheckPrime()
        {
            Console.Write("Enter a number: ");

            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (n <= 1)
            {
                Console.WriteLine("Not a Prime Number.");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine(n + " is a Prime Number.");
            else
                Console.WriteLine(n + " is NOT a Prime Number.");
        }
    }
}