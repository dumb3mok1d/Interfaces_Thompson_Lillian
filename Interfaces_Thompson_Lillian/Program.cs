using System;

namespace Interfaces_Thompson_Lillian
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("E", "FPS", "ZombCube");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movies myMovie = new Movies("PG", "Adventure/Comedy", "Sonic the Hedgehog 2");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
