/*
 * Program: Library Fine Calculator
 * 
 * Description:
 * This program calculates the fine for overdue library books
 * based on the number of days overdue.
 * 
 * Input:
 * - Number of overdue days
 * 
 * Output:
 * - Total fine amount
 * 
 * Rules:
 * - First 7 days → No fine
 * - After 7 days → $0.50 per day
 * 
 * Logic:
 * 1. Take number of days as input
 * 2. If days <= 7 → fine = 0
 * 3. Else → fine = (days - 7) * 0.50
 * 4. Print fine
 */

using System;

namespace basic_code
{
    internal class LibraryFine
    {
        internal void CalculateFine()
        {
            Console.Write("Enter number of overdue days: ");

            string input = Console.ReadLine() ?? "";

            if (!int.TryParse(input, out int days) || days < 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            double fine = 0;

            if (days > 7)
            {
                fine = (days - 7) * 0.50;
            }

            Console.WriteLine("Total Fine = $" + fine.ToString("F2"));
        }
    }
}