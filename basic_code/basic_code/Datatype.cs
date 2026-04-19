using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_code
{
    internal class Datatype
    {
        internal void PDatatype()
        {
            int a = 0;
            byte b = 0;
            float f = 1.23F;
            double d = 34509.34;
            bool bo = false;
            char ch = 'a';
            string s = "Manish";

            Console.WriteLine("a = {0} , b = {1} , f = {2} , d = {3} , bo = {4} , ch = {5} , s = {6}",
                a, b, f, d, bo, ch, s);
        }
        public void DDatatype()
        {
            Int16 a = 0;
            Byte b = 0;
            
            Double d = 6879.34;
            Boolean bo = true;
            Char ch = 'b';
            String s = "Manish kaushal";

            Object o = 12; // object can contain any type of data

            Console.WriteLine("a = {0} , b = {1} , d = {2} , bo = {3} , ch = {4} , s = {5} , o = {6}",
                a, b,  d, bo, ch, s,o);
        }
    }
}
