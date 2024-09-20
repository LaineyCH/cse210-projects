using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = magicNumber + 1;
            Console.WriteLine("Try to guess our magic number!");
            while (guess != magicNumber)
            {
                Console.Write("What is your guess (1-100)? ");
                string userInput = Console.ReadLine();
                guess = int.Parse(userInput);
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.Write("Would you like to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }
    }
}