using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_code
{
    internal class SumOfDateOfBirth
    {
        internal void sumOfDateOfBirth()
        {
            string dob = "03032004";
            int d1 = Convert.ToInt32(dob);
            int sum = 0;
            for (int i = 0; i < dob.Length; i++)
            {
                int rem = d1 % 10;
                
                sum += rem;

                d1 = d1 / 10;

            }
            Console.WriteLine(sum);
        }
    }
}
