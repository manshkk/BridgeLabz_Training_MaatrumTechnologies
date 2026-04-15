using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_code
{
    internal class variable
    {
        internal static void fun() // static method
        { 
            int a = 10;  // static variable
            Console.WriteLine(a);
        }
        internal void fun1() // non static method
        {
            int b = 20;  // instance variable
            Console.WriteLine(b);

        }
    }
}
