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
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        Random random = new Random();
        public int RollingDie()
        {
            Random random = new Random();
            int dieCount = random.Next(1, 7);
            return dieCount;
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
                        playerPosition += RollingDie();
                        Console.WriteLine("The Player move's forward");
                        break;
                    case SNAKE:
                        playerPosition -= RollingDie();
                        Console.WriteLine("The Player move's backward");
                        break;
                        if (playerPosition < 0)
                        {
                            playerPosition = 0;
                        }
                        break;
                }
            }
            Console.WriteLine("Rolling Die : " + RollingDie());
            Console.WriteLine("Player Position : " + playerPosition);
        }
    }
}
