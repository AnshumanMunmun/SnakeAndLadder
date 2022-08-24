using System;
namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSim game = new GameSim();
            game.RollingDie();
            game.Play();
        }
    }
}