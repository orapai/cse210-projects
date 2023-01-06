using System;

class Program
{
    static void Main(string[] args)
    {
        string replay = "yes";
        string play = "yes";

        while (replay == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);
            Console.WriteLine($"What is the magice number? {number}");
            int guessNumber = -1;
            int gameCount = 0;
            while (number != guessNumber)
            {
                Console.Write("What is your guess? ");
                string answer = Console.ReadLine();
                guessNumber = int.Parse(answer);
                gameCount = gameCount + 1;
                if (number > guessNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (number < guessNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Yhay!");
                    if (gameCount > 1)
                    {
                        Console.WriteLine($"You've guessed it in just {gameCount} tries.");
                    }
                    else
                    {
                        Console.WriteLine($"You've guessed it in just {gameCount} try.");
                    }

                    Console.Write("Would you like to play again? ");
                    play = Console.ReadLine();
                    if (play.ToLower() == "yes") 
                    {
                        replay = play;
                    }
                    else 
                    {
                        play = "";
                        replay = play;
                        Console.WriteLine("Thanks for playing!");
                    }
                }
            }
        }
    }
}