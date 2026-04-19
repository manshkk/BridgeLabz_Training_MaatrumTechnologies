/*
 * Program: Rock, Paper, Scissors Game
 * 
 * Description:
 * This program allows a user to play Rock, Paper, Scissors against the computer.
 * The computer randomly selects a choice and the winner is decided based on rules.
 * 
 * Input:
 * - User choice (rock / paper / scissors)
 * 
 * Output:
 * - Computer choice
 * - Result (Win / Lose / Draw)
 * 
 * Rules:
 * - Rock beats Scissors
 * - Scissors beats Paper
 * - Paper beats Rock
 * 
 * Logic:
 * 1. Take user input
 * 2. Generate random choice for computer
 * 3. Compare both choices:
 *      - Same → Draw
 *      - Check winning conditions
 *      - Else → Lose
 * 4. Display result
 */

using System;

namespace basic_code
{
    internal class RockPaperScissors
    {
        internal void PlayGame()
        {
            Console.Write("Enter your choice (rock/paper/scissors): ");
            string userChoice = (Console.ReadLine() ?? "").ToLower();

            if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors")
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            string[] options = { "rock", "paper", "scissors" };
            Random rand = new Random();
            string computerChoice = options[rand.Next(0, 3)];

            Console.WriteLine("Computer chose: " + computerChoice);

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a Draw!");
            }
            else if (
                (userChoice == "rock" && computerChoice == "scissors") ||
                (userChoice == "scissors" && computerChoice == "paper") ||
                (userChoice == "paper" && computerChoice == "rock")
            )
            {
                Console.WriteLine("You Win!");
            }
            else
            {
                Console.WriteLine("You Lose!");
            }
        }
    }
}