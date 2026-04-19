/*
 * Program: Movie Ticket Price Calculator
 * 
 * Description:
 * This program calculates the ticket price based on age and movie time.
 * It applies different pricing for children, adults, seniors and gives
 * a discount for matinee shows.
 * 
 * Input:
 * - Age of customer
 * - Show time (matinee or regular)
 * 
 * Output:
 * - Final ticket price
 * 
 * Pricing Rules:
 * Children (<12): ₹100
 * Adults (12–64): ₹200
 * Seniors (65+): ₹120
 * 
 * Matinee Discount:
 * If show is before 5 PM → 20% discount
 * 
 * Logic:
 * 1. Take age input
 * 2. Determine base price based on age group
 * 3. Ask if show is matinee (before 5 PM)
 * 4. If yes → apply 20% discount
 * 5. Print final price
 */

using System;

namespace basic_code
{
    internal class MovieTicket
    {
        internal void CalculatePrice()
        {
            Console.Write("Enter age: ");

            string ageInput = Console.ReadLine() ?? "";

            if (!int.TryParse(ageInput, out int age) || age < 0)
            {
                Console.WriteLine("Invalid age.");
                return;
            }

            double price;

            // Determine base price
            if (age < 12)
                price = 100;
            else if (age <= 64)
                price = 200;
            else
                price = 120;

            Console.Write("Is it a matinee show (before 5 PM)? (yes/no): ");

            string choice = (Console.ReadLine() ?? "").ToLower();

            if (choice == "yes")
            {
                price = price * 0.8; // 20% discount
            }

            Console.WriteLine("Ticket Price = ₹" + price);
        }
    }
}