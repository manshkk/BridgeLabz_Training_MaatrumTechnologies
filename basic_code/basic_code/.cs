/*
 * Program: Temperature Conversion (Celsius and Fahrenheit)
 * 
 * Description:
 * This program converts temperature between Celsius and Fahrenheit
 * based on user choice.
 * 
 * Input:
 * 1 → Celsius to Fahrenheit
 * 2 → Fahrenheit to Celsius
 * 
 * Output:
 * Converted temperature
 * 
 * Formula:
 * Celsius to Fahrenheit: (C × 9/5) + 32
 * Fahrenheit to Celsius: (F - 32) × 5/9
 * 
 * Logic:
 * 1. Ask user for choice
 * 2. If choice == 1:
 *      - Take Celsius input
 *      - Apply formula → (C × 9/5) + 32
 * 3. Else if choice == 2:
 *      - Take Fahrenheit input
 *      - Apply formula → (F - 32) × 5/9
 * 4. Else → Invalid choice
 */

using System;

namespace basic_code
{
    internal class TemperatureConversion
    {
        internal void ConvertTemperature()
        {
            Console.WriteLine("Choose conversion:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter temperature in Celsius: ");
                    if (double.TryParse(Console.ReadLine(), out double celsius))
                    {
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        Console.WriteLine("Fahrenheit = " + fahrenheit);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;

                case 2:
                    Console.Write("Enter temperature in Fahrenheit: ");
                    if (double.TryParse(Console.ReadLine(), out double fahrenheitInput))
                    {
                        double celsiusResult = (fahrenheitInput - 32) * 5 / 9;
                        Console.WriteLine("Celsius = " + celsiusResult);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}