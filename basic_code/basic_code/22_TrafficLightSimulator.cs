/*
 * Program: Traffic Light Simulator
 * 
 * Description:
 * This program simulates a traffic light system that changes
 * between Red, Yellow, and Green based on time intervals.
 * 
 * Input:
 * - Runs continuously (no user input required)
 * 
 * Output:
 * - Displays current traffic light color
 * 
 * Time Intervals:
 * - Green  → 5 seconds
 * - Yellow → 2 seconds
 * - Red    → 5 seconds
 * 
 * Logic:
 * 1. Use an infinite loop
 * 2. Display Green → wait
 * 3. Display Yellow → wait
 * 4. Display Red → wait
 * 5. Repeat cycle
 */

using System;
using System.Threading;

namespace basic_code
{
    internal class TrafficLightSimulator
    {
        internal void StartSimulation()
        {
            while (true)
            {
                // Green Light
                Console.WriteLine("GREEN Light - Go!");
                Thread.Sleep(5000);

                // Yellow Light
                Console.WriteLine("YELLOW Light - Get Ready!");
                Thread.Sleep(2000);

                // Red Light
                Console.WriteLine("RED Light - Stop!");
                Thread.Sleep(5000);

                Console.WriteLine("---------------------------");
            }
        }
    }
}