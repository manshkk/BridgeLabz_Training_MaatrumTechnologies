/*
 * C# Program to Check Whether an Alphabet is Vowel or Consonant
 */

using System;

namespace basic_code
{
    internal class VowelConsonant
    {
        internal void CheckAlphabet()
        {
            Console.Write("Enter a character: ");

            string input = Console.ReadLine() ?? "";

            if (string.IsNullOrEmpty(input) || input.Length != 1)
            {
                Console.WriteLine("Please enter a single character.");
                return;
            }

            char ch = char.ToLower(input[0]);

            if (!char.IsLetter(ch))
            {
                Console.WriteLine("Invalid input. Please enter an alphabet.");
                return;
            }

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine($"'{ch}' is a Vowel");
            }
            else
            {
                Console.WriteLine($"'{ch}' is a Consonant");
            }
        }
    }
}