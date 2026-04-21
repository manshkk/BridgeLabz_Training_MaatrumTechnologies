using System;

namespace basic_code
{
    internal class SnakeAndLadderTwoPlayer
    {
        internal void Play()
        {
            int p1 = 0, p2 = 0;
            int turn = 1;

            Random rand = new Random();

            while (p1 < 100 && p2 < 100)
            {
                int dice = rand.Next(1, 7);
                int option = rand.Next(0, 3);

                Console.WriteLine($"\nPlayer {turn} rolled: {dice}");

                int position = (turn == 1) ? p1 : p2;

                if (option == 1) // Ladder
                {
                    Console.WriteLine("Ladder");
                    if (position + dice <= 100)
                        position += dice;
                }
                else if (option == 2) // Snake
                {
                    Console.WriteLine("Snake");
                    position -= dice;
                    if (position < 0) position = 0;
                }
                else
                {
                    Console.WriteLine("No Play");
                }

                if (turn == 1) p1 = position;
                else p2 = position;

                Console.WriteLine($"P1: {p1} | P2: {p2}");

                // Ladder → same player again
                if (option != 1)
                    turn = (turn == 1) ? 2 : 1;
            }

            Console.WriteLine(p1 == 100 ? "Player 1 Wins!" : "Player 2 Wins!");
        }
    }
}
