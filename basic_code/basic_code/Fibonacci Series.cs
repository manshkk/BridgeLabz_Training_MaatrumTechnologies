/*
 * 🧠 Logic
First two numbers: 0, 1
Next number = sum of previous two
0, 1, 1, 2, 3, 5, 8, 13...
*/
using System;

namespace basic_code
{
    internal class FibonacciSeries
    {
        internal void GenerateSeries()
        {
            Console.Write("Enter number of terms: ");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            int first = 0, second = 1;

            Console.Write("Fibonacci Series: ");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(first + " ");

                int next = first + second;
                first = second;
                second = next;
            }

            Console.WriteLine();
        }
    }
}