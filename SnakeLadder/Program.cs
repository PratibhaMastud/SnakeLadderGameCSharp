using System;

namespace SnakeLadder
{
    class Program
    {
        // Function to roll a dice
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
            Console.WriteLine("Welcome to Snake and Ladder");
            int playerPosition = 0;
            int numberOfRollsdice = 0;
            int winPosition = 100;
            //repeat till win position i.e. till 100

            while (playerPosition != 100)
            {
                int playerDice = rollDice();
                int option = checkOption();
                numberOfRollsdice++;

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Players not play");
                        break;
                    case 2:
                        Console.WriteLine("Player got the Ladder");
                        playerPosition += playerDice;
                        //ensure win position 100
                        if (playerPosition > winPosition)
                        {
                            playerPosition -= playerDice;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Player got the Snake");
                        //In case player position moves below 0, then player starts from zero position  
                        if ((playerPosition - playerDice) < 0)
                        {
                            playerPosition = 0;
                        }
                        else
                        {
                            playerPosition -= playerDice;
                        }
                        break;
                    default:
                        Console.WriteLine("Something Went Wrong");
                        break;
                }
            }
            if (playerPosition == winPosition)
            {
                Console.WriteLine("Player got {0} position and is the winner ", playerPosition);
                Console.WriteLine("The Number of roll dice are {0}  ", numberOfRollsdice);
            }
        }
    }
}

