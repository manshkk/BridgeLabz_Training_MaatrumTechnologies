/*
 * Program: Menu-Driven Calculator
 * 
 * Description:
 * This program performs basic arithmetic operations based on user choice.
 * 
 * Input:
 * - Two numbers
 * - Operation choice (1–4)
 * 
 * Output:
 * - Result of operation
 * 
 * Operations:
 * 1 → Addition
 * 2 → Subtraction
 * 3 → Multiplication
 * 4 → Division
 * 
 * Logic:
 * 1. Take two numbers as input
 * 2. Display operation menu
 * 3. Take user choice
 * 4. Use switch-case:
 *      - Perform selected operation
 *      - Handle division by zero
 * 5. Print result
 */

using System;

namespace basic_code
{
    internal class CalculatorProgram
    {
        internal void Calculate()
        {
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.WriteLine("Choose operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            double result;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Result = " + result);
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                        return;
                    }
                    result = num1 / num2;
                    Console.WriteLine("Result = " + result);
                    break;

                default:
                    Console.WriteLine("Invalid operation choice.");
                    break;
            }
        }
    }
}