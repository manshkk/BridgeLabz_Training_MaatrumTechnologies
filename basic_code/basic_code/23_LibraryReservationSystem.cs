/*
 * Program: Library Reservation System
 * 
 * Description:
 * This program allows users to check book availability and reserve books.
 * It manages reservations based on availability, user limits, and duration.
 * 
 * Input:
 * - Book name
 * - Number of books user already reserved
 * - Reservation days
 * 
 * Output:
 * - Reservation success or failure message
 * 
 * Rules:
 * - Book must be available
 * - User can reserve maximum 3 books
 * - Reservation duration must be <= 7 days
 * 
 * Logic:
 * 1. Store available books
 * 2. Ask user for book name
 * 3. Check if book exists
 * 4. Check user reservation limit
 * 5. Check reservation duration
 * 6. If all conditions satisfied → reserve book
 */

using System;

namespace basic_code
{
    internal class LibraryReservationSystem
    {
        internal void ReserveBook()
        {
            string[] books = { "C#", "Java", "Python", "Data Structures" };

            Console.Write("Enter book name: ");
            string book = (Console.ReadLine() ?? "").Trim();

            bool isAvailable = false;

            foreach (string b in books)
            {
                if (b.Equals(book, StringComparison.OrdinalIgnoreCase))
                {
                    isAvailable = true;
                    break;
                }
            }

            if (!isAvailable)
            {
                Console.WriteLine("Book not available.");
                return;
            }

            Console.Write("Enter number of books already reserved: ");
            string reservedInput = Console.ReadLine() ?? "";

            if (!int.TryParse(reservedInput, out int reserved) || reserved < 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (reserved >= 3)
            {
                Console.WriteLine("Reservation limit reached (max 3 books).");
                return;
            }

            Console.Write("Enter reservation days (max 7 days): ");
            string daysInput = Console.ReadLine() ?? "";

            if (!int.TryParse(daysInput, out int days) || days <= 0 || days > 7)
            {
                Console.WriteLine("Invalid reservation duration.");
                return;
            }

            Console.WriteLine("Book reserved successfully for " + days + " days.");
        }
    }
}