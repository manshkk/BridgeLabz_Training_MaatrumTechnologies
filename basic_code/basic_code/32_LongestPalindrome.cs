/*
 * Program: Longest Palindromic Substring
 */

using System;

namespace basic_code
{
    internal class LongestPalindrome
    {
        internal void Find()
        {
            Console.Write("Enter string: ");
            string s = Console.ReadLine() ?? "";

            string res = "";

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    string sub = s.Substring(i, j - i + 1);
                    if (IsPalindrome(sub) && sub.Length > res.Length)
                        res = sub;
                }
            }

            Console.WriteLine("Longest Palindrome: " + res);
        }

        private bool IsPalindrome(string str)
        {
            int l = 0, r = str.Length - 1;
            while (l < r)
            {
                if (str[l++] != str[r--]) return false;
            }
            return true;
        }
    }
}