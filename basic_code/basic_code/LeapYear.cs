using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_code
{
    internal class LeapYearFind
    {
        internal void leapYear()
        {
            Console.Write("Enter a year : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 400 == 0 || (num % 4 == 0 && num % 100 != 0))
            {
                Console.WriteLine("{0} is a leap year ", num);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year ", num);
            }
        }
    }
}
