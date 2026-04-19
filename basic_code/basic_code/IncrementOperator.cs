using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_code
{
    internal class IncrementOperator
    {
        internal void postIncreamentOperator()
        {
            int a = 10;
            int b = a++ + a++ + a++; // a++ post increment
            

            Console.WriteLine("a = {0} and b = {1} ", a , b );
        }
        internal void preIncreamentOperator()
        {
            int a = 10;
            int c = ++a + ++a + ++a; // ++a pre increment

            Console.WriteLine("a = {0}  and c = {1}", a,  c);
        }
    }
}

