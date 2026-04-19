/*
 3. Power of 2
a. Desc -> This program takes a command-line argument N and prints a table of the
powers of 2 that are less than or equal to 2^N.
b. I/P -> The Power Value N. Only works if 0 <= N < 31 since 2^31 overflows an int
c. Logic -> repeat until i equals N.
 */
using System;

namespace basic_code
{
    internal class PowerOf2
    {
        internal void CalculatePower()
        {
            Console.Write("Enter value of N (0 <= N < 31): ");

            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0 || n >= 31)
            {
                Console.WriteLine("Invalid input. Please enter value between 0 and 30.");
                return;
            }

            int result = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"2^{i} = {result}");
                result *= 2; // multiply by 2 each time
            }
        }
    }
}
