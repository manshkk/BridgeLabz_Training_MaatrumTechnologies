/*
 4. Harmonic Number
a. Desc -> Prints the Nth harmonic number: 1/1 + 1/2 + ... + 1/N
(http://users.encs.concordia.ca/~chvatal/notes/harmonic.html).
b. I/P -> The Harmonic Value N. Ensure N != 0
c. Logic -> compute 1/1 + 1/2 + 1/3 + ... + 1/N
d. O/P -> Print the Nth Harmonic Value.
 */
using System;

namespace basic_code
{
    internal class HarmonicNumber
    {
        internal void CalculateHarmonic()
        {
            Console.Write("Enter value of N (N != 0): ");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input. N must be greater than 0.");
                return;
            }

            double harmonic = 0.0;

            for (int i = 1; i <= n; i++)
            {
                harmonic += 1.0 / i;
            }

            Console.WriteLine("Harmonic value = " + harmonic.ToString("F3"));
        }
    }
}
