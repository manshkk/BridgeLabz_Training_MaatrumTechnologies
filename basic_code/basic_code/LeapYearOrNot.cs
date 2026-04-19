/*
2. Leap Year
a. I/P -> Year, ensure it is a 4 digit number.
b. Logic -> Determine if it is a Leap Year.
c. O/P -> Print the year is a Leap Year or not.
*/

using System;

namespace basic_code
{
    internal class LeapYear
    {
        internal void CheckLeapYear()
        {
            Console.Write("Enter a 4-digit year: ");

            if (!int.TryParse(Console.ReadLine(), out int year) || year < 1000 || year > 9999)
            {
                Console.WriteLine("Please enter a valid 4-digit year.");
                return;
            }

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " is NOT a Leap Year.");
            }
        }
    }
}