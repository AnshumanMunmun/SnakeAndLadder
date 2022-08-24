using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class GameSim
    {
        public int playerPosition = 0;
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        Random random = new Random();
        public int RollingDice()
        {
            Random random = new Random();
            int diceCount = random.Next(1, 7);
            return diceCount;
        }
        public void Play()
        {
            while (playerPosition < 100)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        playerPosition += 0;
                        Console.WriteLine("The Player Stay's in the same position");
                        break;
                    case LADDER:
                        playerPosition += RollingDice();
                        if (playerPosition > 100)
                        {
                            playerPosition -= RollingDice();
                        }
                        Console.WriteLine("The Player move's forward");
                        break;
                    case SNAKE:
                        playerPosition -= RollingDice();
                        if (playerPosition < 0)
                        {
                            playerPosition = 0;
                        }
                        Console.WriteLine("The Player move's backward");
                        break;
                }
            }
            if (playerPosition == WINNING_POSITION)
            {
                Console.WriteLine("Rolling Dice : " + RollingDice());
                Console.WriteLine("Player Position : " + playerPosition);
            }
        }
    }
}
