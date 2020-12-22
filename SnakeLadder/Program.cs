using System;

namespace SnakeLadder
{
    class Program
    {
        public static int rollDice()
        {
            Random random = new Random();
            int dicevalue = random.Next(1, 7);
            return dicevalue;
        }

        //Function to check Player get a Ladder or snake or player play or not
        public static int checkOption()
        {
            Random random = new Random();

            return random.Next(1, 4);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder ");
            int Player1Position = 0;
            int Player2Position = 0;
            int Player1RollDiceCount = 0;
            int Player2RollDiceCount = 0;
            int WinPosition = 100;

            while (Player1Position != 100 || Player2Position != 100)
            {
                int Player1Dice = rollDice();
                Player1RollDiceCount++;
                int Player2Dice = rollDice();
                Player2RollDiceCount++;
                int option = checkOption();

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Players not play");
                        break;
                    case 2:
                        Console.WriteLine("Player got the Ladder");
                        Player1Position += Player1Dice;
                        Player2Position += Player2Dice;

                        if (Player1Position > WinPosition)
                        {
                            Player1Position -= Player1Dice;
                        }
                        else if (Player2Position > WinPosition)
                        {
                            Player2Position -= Player2Dice;
                        }
                        Console.WriteLine("Player1 position is now on {0}", Player1Position);
                        Console.WriteLine("Player2 position is now on {0}", Player2Position);
                        break;
                    case 3:
                        Console.WriteLine("Player got the Snake");
                        if ((Player1Position - Player1Dice) < 0)
                        {
                            Player1Position = 0;
                        }
                        else
                        {
                            Player1Position -= Player1Dice;
                        }
                        if ((Player2Position - Player2Dice) < 0)
                        {
                            Player2Position = 0;
                        }
                        else
                        {
                            Player2Position -= Player2Dice;
                        }
                        Console.WriteLine("Player1 position is now on {0}", Player1Position);
                        Console.WriteLine("Player2 position is now on {0}", Player2Position);
                        break;
                    default:
                        Console.WriteLine("Something Went Wrong");
                        break;
                }

                //Report the number of times the dice was played to win the game and also the position after every die role
                if (Player1Position == WinPosition || Player2Position == WinPosition)
                {
                    if (Player1Position == WinPosition)
                    {
                        Console.WriteLine("Number of times dice was played by player to win the game is {0}", Player1RollDiceCount);
                    }
                    else if (Player2Position == WinPosition)
                    {
                        Console.WriteLine("Number of times dice was played by player to win the game is {0}", Player2RollDiceCount);
                    }
                }
            }
        }
    }
}
