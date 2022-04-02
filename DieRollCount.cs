using System;

namespace Snake_and_Ladder
{
    class SnakeandLadder
    {
        public const int NoPlay = 1;
        public const int IsLadder = 2;
        public const int IsSnake = 3;
        static void Main(string[] args)
        {
            //Variables
            int Position = 0;
            int rolls = 0;
            int option = 0;
            int winningPosition = 100;
            int dieRollCount = 0;
            Console.WriteLine("Player is at Position: " + Position);

            //Untill Winning Position 100
            while (Position < winningPosition)
            {
                //Roll dai Using Random Function
                Random random = new Random();

                while (true)
                {
                    rolls = random.Next(7);
                    if (rolls != 0)
                        break;
                }
                Console.WriteLine("Rolls: " + rolls);

                //Option for Player
                Random randomNum = new Random();
                dieRollCount++;
                while (true)
                {
                    option = randomNum.Next(0, 3);
                    if (option != 0)
                        break;
                }
                Console.WriteLine("Options: \nOption 1 : No Play \nOption 2 : Ladder \nOption3 : Snake \n");
                Console.WriteLine("Option : " + option);

                switch (option)
                {
                    case NoPlay:
                        Console.WriteLine("No Play! Player Stay at same position: " + Position);
                        break;

                    case IsLadder:
                        if (Position > winningPosition)
                        {
                            Position = winningPosition;
                        }
                        else
                        {
                            Position += rolls;
                        }
                        Console.WriteLine("Ladder! Player Move Ahead by Position: " + Position);
                        break;

                    case IsSnake:
                        Position -= rolls;
                        if (Position < 0)
                        {
                            Position = 0;
                        }
                        Console.WriteLine("Snake! Player Move Behind by Position: " + Position);
                        break;
                    default:
                        Console.WriteLine("You Can't Play! Please Enter Correct Value");
                        break;

                }
            }
            Console.WriteLine("\nNumber Of Times The Dice Was Played To Win The Game Is : " + dieRollCount);
        }

    }
}