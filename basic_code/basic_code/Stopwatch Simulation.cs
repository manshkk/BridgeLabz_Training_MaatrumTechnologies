/*
 * Program: Simulate Stopwatch
 * 
 * Description:
 * This program measures the time elapsed between start and stop actions.
 * 
 * Input:
 * User presses Enter to start and Enter again to stop
 * 
 * Output:
 * Elapsed time in seconds
 * 
 * Logic:
 * 1. Wait for user to press Enter (start)
 * 2. Record start time
 * 3. Wait for user to press Enter again (stop)
 * 4. Record end time
 * 5. Calculate difference (end - start)
 * 6. Display elapsed time
 */

using System;
using System.Diagnostics;

namespace basic_code
{
    internal class StopwatchProgram
    {
        internal void MeasureTime()
        {
            Console.WriteLine("Press Enter to START stopwatch...");
            Console.ReadLine();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Press Enter to STOP stopwatch...");
            Console.ReadLine();

            stopwatch.Stop();

            Console.WriteLine("Elapsed Time: " + stopwatch.Elapsed.TotalSeconds + " seconds");
        }
    }
}