using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_code
{
    internal class BoxingExample
{
    internal void Boxingfun()
    {
        int a = 1;
        Object o;
        o = a;
        Console.WriteLine(o);
    }
        internal void unBoxingfun()
        {
            Object o = 10;
            int a = (int)o;
            Console.WriteLine(a);
        }
}
}
