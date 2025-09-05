using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.WriteLine("What is the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());

        int userGuess = -1;

        while (userGuess != magicNumber)
        {
            Console.WriteLine("Guess the magic number:");
            userGuess = int.Parse(Console.ReadLine());

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
                Console.WriteLine("Congratulations! You guessed the magic number.");
            }
        }
    }
}
