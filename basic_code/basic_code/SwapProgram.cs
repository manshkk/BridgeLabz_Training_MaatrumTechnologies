using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_code
{
    internal class SwapProgram
    {
        static int a = 10, b = 20;
        internal static void swap()
        {
            int temp;
            Console.WriteLine("Before swapping: a = " + a + ", b = " + b);
            temp = a; // temp now holds the value of a
            a = b;    // a now holds the value of b
            b = temp; // b now holds the value of temp (which is the original value of a)
            Console.WriteLine("After swapping: a = " + a + ", b = " + b);
        }
    }
}
