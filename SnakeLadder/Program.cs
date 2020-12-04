using System;

namespace SnakeLadder
{
    class Program
    {
        static int noPlay = 0;
        static int startPosition = 0;
        public static int rollDiceNumber()
        {
            Random random = new Random();
            int diceNumber = random.Next(0, 7);
            return diceNumber;
        }

        public static int playLadder()
        {
            Random random = new Random();
            int ladderStep = random.Next(0, 7);
            Console.WriteLine(ladderStep);
            return ladderStep;
        }
        public static int snackAttack()
        {
            Random random = new Random();
            int snackBite = random.Next(0, 7);
            return snackBite;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
           int currentPosition = 0;
            while (currentPosition != 100)
            {
                int numberDice = rollDiceNumber();
                Random random = new Random();
                int option = random.Next(1, 3);
                // Use Switch case for option
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Got ladder");
                        currentPosition = currentPosition + playLadder();
                        break;
                    case 2:
                        Console.WriteLine("Snake attack");
                        currentPosition = currentPosition - snackAttack();
                        break;
                   
                }
            }
        }
    }
}
