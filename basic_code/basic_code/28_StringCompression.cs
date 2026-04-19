/*
 * Program: String Compression
 */

using System;
using System.Text;

namespace basic_code
{
    internal class StringCompression
    {
        internal void Compress()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine() ?? "";

            StringBuilder result = new StringBuilder();
            int count = 1;

            for (int i = 1; i <= str.Length; i++)
            {
                if (i < str.Length && str[i] == str[i - 1])
                {
                    count++;
                }
                else
                {
                    result.Append(str[i - 1]);
                    result.Append(count);
                    count = 1;
                }
            }

            Console.WriteLine("Compressed: " + result);
        }
    }
}