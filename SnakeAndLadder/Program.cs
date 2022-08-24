using System;
namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSim game = new GameSim();
            Console.WriteLine(game.playerPosition);
        }
    }
}