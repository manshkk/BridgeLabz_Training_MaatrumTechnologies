/*
 5. Factors
a. Desc -> Computes the prime factorization of N using brute force.
b. I/P -> Number to find the prime factors
c. Logic -> Traverse till i*i <= N instead of i <= N for efficiency.
d. O/P -> Print the prime factors of number N.
 */
using System;

namespace basic_code
{
    internal class PrimeFactors
    {
        internal void FindFactors()
        {
            Console.Write("Enter a number: ");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 1)
            {
                Console.WriteLine("Please enter a number greater than 1.");
                return;
            }

            Console.Write("Prime factors: ");

            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }

            // If remaining number is greater than 1
            if (n > 1)
            {
                Console.Write(n);
            }

            Console.WriteLine();
        }
    }
}
