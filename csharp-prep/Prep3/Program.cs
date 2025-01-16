
using System;

class Program
{
    static void Main()
    {
        string playAgain;
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess;
            int attempts = 0;

            Console.WriteLine("Welcome! Are you ready to challenge your number guessing wits, maybe impress your girlfriend too!?");

            do
            {
                Console.Write("Your move! What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Nope! Go Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Wrong! Go Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {attempts} attempts!");
                }

            } while (guess != magicNumber);

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}
