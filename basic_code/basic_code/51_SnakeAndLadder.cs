/*
 * Program: Snake and Ladder Game
 * 
 * Description:
 * Simulates Snake & Ladder game using all UC rules
 * 
 * Concepts:
 * - Random number generation
 * - Loop simulation
 * - Conditional logic
 * - Game state tracking
 */

using System;

namespace basic_code
{
    internal class SnakeAndLadder
    {
        internal void Play()
        {
            int position = 0;
            int diceCount = 0;

            Random rand = new Random();

            while (position < 100)
            {
                int dice = rand.Next(1, 7);
                int option = rand.Next(0, 3); // 0=NoPlay,1=Ladder,2=Snake

                diceCount++;

                Console.WriteLine($"Dice: {dice}");

                if (option == 0)
                {
                    Console.WriteLine("No Play");
                }
                else if (option == 1)
                {
                    Console.WriteLine("Ladder");
                    if (position + dice <= 100)
                        position += dice;
                }
                else
                {
                    Console.WriteLine("Snake");
                    position -= dice;

                    if (position < 0)
                        position = 0;
                }

                Console.WriteLine("Position: " + position);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("🎉 Reached 100!");
            Console.WriteLine("Total Dice Rolls: " + diceCount);
        }
    }
}
