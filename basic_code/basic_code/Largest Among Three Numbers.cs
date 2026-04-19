/*
 * This program finds the largest among three numbers entered by the user.
 * It uses if-else statements to compare the numbers and determine the largest one.
 * The program also includes input validation to ensure that the user enters valid integers.
 * 🧠 Logic
Take 3 numbers: a, b, c
Compare:
If a >= b && a >= c → a is largest
Else if b >= c → b is largest
Else → c is largest
 */
using System;

namespace basic_code
{
    internal class LargestOfThree
    {
        internal void FindLargest()
        {
            Console.Write("Enter first number: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.Write("Enter second number: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.Write("Enter third number: ");
            if (!int.TryParse(Console.ReadLine(), out int c))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (a >= b && a >= c)
            {
                Console.WriteLine("Largest number is: " + a);
            }
            else if (b >= c)
            {
                Console.WriteLine("Largest number is: " + b);
            }
            else
            {
                Console.WriteLine("Largest number is: " + c);
            }
        }
    }
}
