/*
1. Flip Coin and print percentage of Heads and Tails
a. I/P -> The number of times to Flip Coin. Ensure it is a positive integer.
b. Logic -> Use Random Function to get value between 0 and 1. If < 0.5 then tails or
heads
c. O/P -> Percentage of Head vs Tails
*/

using System;

namespace basic_code
{
    internal class FlipCoin
    {
        internal void FlipCoinPercentage()
        {
            Console.Write("Enter number of times to flip the coin: ");

            // Validate input
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
                return;
            }

            int heads = 0;
            int tails = 0;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                double result = random.NextDouble(); // value between 0.0 and 1.0

                if (result < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }

            double headPercentage = (heads * 100.0) / n;
            double tailPercentage = (tails * 100.0) / n;

            Console.WriteLine("Heads Percentage: " + headPercentage + "%");
            Console.WriteLine("Tails Percentage: " + tailPercentage + "%");
        }
    }
}
