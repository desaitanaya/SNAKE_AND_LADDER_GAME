using System.Security.Cryptography.X509Certificates;

namespace SnakeLadderGame
{
    
    class Program
    {
        static void Main(string[] args)
        {
            SnakeLadder snakeLadder = new SnakeLadder();

            Console.WriteLine("Enter Player name :");
            snakeLadder.playerName = Console.ReadLine();

            snakeLadder.DiceRoll();

        }
    }
}

