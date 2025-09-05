using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Create a random number generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);


        int userGuess = -1;
        int userGuessCount = 0;


        while (userGuess != magicNumber)
        {
            Console.WriteLine("Guess the magic number:");
            userGuess = int.Parse(Console.ReadLine());
            userGuessCount++;

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed the magic number. It took you {userGuessCount} guesses");
            }
        }
    }
}
