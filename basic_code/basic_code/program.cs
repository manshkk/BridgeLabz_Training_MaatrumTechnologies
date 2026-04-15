using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_code
{
    internal class program
    {
        static int y = 100; // static variable
        int x = 10; // instance variable
        static void Main(string[] args)
        {
            int y = 10;
            y = 20;
            Console.WriteLine("Local variable y = " + y);
            Console.WriteLine("Static variable y = " + program.y);

            program p1 = new program();

            Console.WriteLine("Instance variable x = " + p1.x);
            variable v1 = new variable();
            v1.fun1();
            variable.fun();

            const String name = "C# Programming";
            Console.WriteLine("Constant name = " + name);

            SwapProgram.swap();
        }
    }
}
