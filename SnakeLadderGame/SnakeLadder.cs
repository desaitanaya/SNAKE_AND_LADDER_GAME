using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class SnakeLadder
    {
        public string playerName;

        public int playerPosition = 0;

        public int diceRoll1;

        public bool endOfGame = false;

        public void DiceRoll()
        {
            Random random = new Random();
            Dictionary<int, int> snake = new Dictionary<int, int>
            {
                {37 ,3}, //Snake: from 37 to 3
                {28, 10},
                {47,16},
                {75,32},
                {94,71},
                {96,42}
            };


            Dictionary<int, int> ladder = new Dictionary<int, int>
            {
                {4,56 },
                {12,50 },
                {14, 55 },
                {22,58 },
                {41,79 },
                {54,88 }
            };

            while (!endOfGame)
            {

                int diceRoll = random.Next(1, 7);
                Console.WriteLine("Dice Rolled :" + diceRoll);

                playerPosition += diceRoll;
                Console.WriteLine("Position of Player : " + playerPosition);
                Console.WriteLine("---------------------------------------");



                if (snake.ContainsKey(playerPosition))
                {
                    int newPosition = snake[playerPosition];
                    if (newPosition < playerPosition)
                    {

                        Console.WriteLine("Player got bitten by a snake!");
                        Console.WriteLine("---------------------------------------");

                    }
                    playerPosition = newPosition;

                }

                else if (ladder.ContainsKey(playerPosition))
                {
                    int newPosition = ladder[playerPosition];
                    if (newPosition > playerPosition)
                    {

                        Console.WriteLine("Player climbed a ladder! ");
                        Console.WriteLine("---------------------------------------");

                    }
                    playerPosition = newPosition;
                }

                if (playerPosition != 96)
                {
                    if (playerPosition >= 95)
                    {
                        if (playerPosition == 95)
                        {
                            diceRoll = random.Next(1, 6);
                            Console.WriteLine("Dice Rolled : " + diceRoll);
                            playerPosition += diceRoll;
                            Console.WriteLine("Position of Player : " + playerPosition);
                            Console.WriteLine("---------------------------------------");

                            if (playerPosition == 97)

                            {
                                diceRoll = random.Next(1, 4);
                                Console.WriteLine("Dice Rolled : " + diceRoll);
                                playerPosition += diceRoll;
                                Console.WriteLine("Position of Player : " + playerPosition);
                                Console.WriteLine("---------------------------------------");


                                if (playerPosition == 98)
                                {
                                    diceRoll = random.Next(1, 3);
                                    Console.WriteLine("Dice Rolled : " + diceRoll);
                                    playerPosition += diceRoll;
                                    Console.WriteLine("Position of Player : " + playerPosition);
                                    Console.WriteLine("---------------------------------------");


                                    if (playerPosition == 99)
                                    {
                                        diceRoll = random.Next(1, 2);
                                        Console.WriteLine("Dice Rolled : " + diceRoll);
                                        playerPosition += diceRoll;
                                        Console.WriteLine("Position of Player : " + playerPosition);
                                        Console.WriteLine("---------------------------------------");

                                    }
                                }
                            }
                        }

                        if (playerPosition == 97)
                        {
                            diceRoll = random.Next(1, 4);
                            Console.WriteLine("Dice Rolled : " + diceRoll);
                            playerPosition += diceRoll;
                            Console.WriteLine("Position of Player : " + playerPosition);
                            Console.WriteLine("---------------------------------------");


                            if (playerPosition == 98)
                            {
                                diceRoll = random.Next(1, 3);
                                Console.WriteLine("Dice Rolled : " + diceRoll);
                                playerPosition += diceRoll;
                                Console.WriteLine("Position of Player : " + playerPosition);
                                Console.WriteLine("---------------------------------------");


                                if (playerPosition == 99)
                                {
                                    diceRoll = random.Next(1, 2);
                                    Console.WriteLine("Dice Rolled : " + diceRoll);
                                    playerPosition += diceRoll;
                                    Console.WriteLine("Position of Player : " + playerPosition);
                                    Console.WriteLine("---------------------------------------");

                                }
                            }
                        }

                        if (playerPosition == 98)
                        {
                            diceRoll = random.Next(1, 3);
                            Console.WriteLine("Dice Rolled : " + diceRoll);
                            playerPosition += diceRoll;
                            Console.WriteLine("Position of Player : " + playerPosition);
                            Console.WriteLine("---------------------------------------");


                            if (playerPosition == 99)
                            {
                                diceRoll = random.Next(1, 2);
                                Console.WriteLine("Dice Rolled : " + diceRoll);
                                playerPosition += diceRoll;
                                Console.WriteLine("Position of Player : " + playerPosition);
                                Console.WriteLine("---------------------------------------");

                            }

                        }

                        if (playerPosition == 99)
                        {
                            diceRoll = random.Next(1, 2);
                            Console.WriteLine("Dice Rolled : " + diceRoll);
                            playerPosition += diceRoll;
                            Console.WriteLine("Position of Player : " + playerPosition);
                            Console.WriteLine("---------------------------------------");

                        }

                        if (playerPosition >= 100)
                        {
                            Console.WriteLine("Player " + playerName + " has won the game!");
                            endOfGame = true;
                        }
                    }

                }
            }
        }

    }


}
