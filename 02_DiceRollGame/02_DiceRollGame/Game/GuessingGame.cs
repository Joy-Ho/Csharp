//Random rnd = new Random();
//string result = rnd.Next(1, 7).ToString();
//Console.WriteLine("Guess a number from 1 to 6: ");

//string guess = Console.ReadLine();



//int tries = 1;
//while (tries < 3)
//{
//    if (guess == result)
//    {
//        Console.WriteLine("You win");
//        return;
//    }
//    else 
//    {
//        if (guess == "1" || guess == "2" || guess == "3" || guess == "4" || guess == "5" || guess == "6")
//        {
//            Console.WriteLine("Wrong number.");
//        }
//        else
//        {
//            Console.WriteLine("Incorrect input");
//        }
//        tries++;
//        Console.WriteLine(" Enter a number from 1 to 6: ");
//        guess = Console.ReadLine();
//    }

//}
//Console.WriteLine("Wrong number. You lose.");

using DiceRollGame.UserCommunication;

namespace DiceRollGame.Game
{
    class GuessingGame
    {
        private readonly Dice _dice;
        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine("" +
                "Dice rolled. Guess what number it shows in {InitialTries} trials.");

            var triesLeft = InitialTries;
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number:");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong number");
                --triesLeft;
            }
            return GameResult.Loss;
        }

        public static void PrintResult(GameResult gameResult)
        {
            string message;
            if (gameResult == GameResult.Victory)
            {
                message = "You win!";
            }
            else
            {
                message = "You lose :(";
            }
            Console.WriteLine(message);
        }
    }
}