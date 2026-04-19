/*
 * Program: Air Quality Index (AQI) Calculator
 * 
 * Description:
 * This program calculates AQI based on pollutant concentration
 * and classifies it into categories like Good, Moderate, Unhealthy, etc.
 * 
 * Input:
 * - Pollutant concentration (PM2.5 in µg/m³)
 * 
 * Output:
 * - AQI category
 * 
 * AQI Categories (Based on PM2.5):
 * 0 – 50   → Good
 * 51 – 100 → Moderate
 * 101 – 150 → Unhealthy for Sensitive Groups
 * 151 – 200 → Unhealthy
 * 201 – 300 → Very Unhealthy
 * 301+      → Hazardous
 * 
 * Logic:
 * 1. Take pollutant concentration input
 * 2. Validate input (>= 0)
 * 3. Use if-else conditions to classify AQI
 * 4. Print AQI category
 */

using System;

namespace basic_code
{
    internal class AQIProgram
    {
        internal void CalculateAQI()
        {
            Console.Write("Enter PM2.5 concentration (µg/m³): ");

            if (!double.TryParse(Console.ReadLine(), out double pm25) || pm25 < 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            string category;

            if (pm25 <= 50)
                category = "Good";
            else if (pm25 <= 100)
                category = "Moderate";
            else if (pm25 <= 150)
                category = "Unhealthy for Sensitive Groups";
            else if (pm25 <= 200)
                category = "Unhealthy";
            else if (pm25 <= 300)
                category = "Very Unhealthy";
            else
                category = "Hazardous";

            Console.WriteLine("AQI Category: " + category);
        }
    }
}
