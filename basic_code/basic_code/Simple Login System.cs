/*
 * Program: Simple Login System
 * 
 * Description:
 * This program simulates a basic login system where user enters
 * username and password. It validates credentials and handles
 * incorrect attempts with account lock feature.
 * 
 * Input:
 * - Username
 * - Password
 * 
 * Output:
 * - Login Successful
 * - Incorrect Username
 * - Incorrect Password
 * - Account Locked (after 3 failed attempts)
 * 
 * Logic:
 * 1. Store predefined username and password
 * 2. Allow maximum 3 login attempts
 * 3. If username is incorrect → show message
 * 4. If username correct but password wrong → show message
 * 5. If both correct → login successful
 * 6. After 3 failed attempts → lock account
 */

using System;

namespace basic_code
{
    internal class LoginSystem
    {
        internal void Login()
        {
            string correctUsername = "admin";
            string correctPassword = "1234";

            int attempts = 0;
            const int maxAttempts = 3;

            while (attempts < maxAttempts)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine() ?? "";

                Console.Write("Enter password: ");
                string password = Console.ReadLine() ?? "";

                if (username != correctUsername)
                {
                    Console.WriteLine("Incorrect Username.");
                }
                else if (password != correctPassword)
                {
                    Console.WriteLine("Incorrect Password.");
                }
                else
                {
                    Console.WriteLine("Login Successful!");
                    return;
                }

                attempts++;
                Console.WriteLine("Attempts left: " + (maxAttempts - attempts));
            }

            Console.WriteLine("Account Locked. Too many failed attempts.");
        }
    }
}