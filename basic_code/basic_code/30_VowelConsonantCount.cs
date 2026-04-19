/*
 * Program: Count Vowels and Consonants
 */

using System;

namespace basic_code
{
    internal class VowelConsonantCount
    {
        internal void Count()
        {
            Console.Write("Enter string: ");
            string str = (Console.ReadLine() ?? "").ToLower();

            int vowels = 0, consonants = 0;

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    if ("aeiou".Contains(c))
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
        }
    }
}