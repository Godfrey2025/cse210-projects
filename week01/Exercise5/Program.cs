using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

     // Call DisplayWelcome function
        DisplayWelcome();

        // Call PromptUserName and store the result
        string userName = PromptUserName();

        // Call PromptUserNumber and store the result
        int favoriteNumber = PromptUserNumber();

        // Call SquareNumber to compute the square
        int squaredNumber = SquareNumber(favoriteNumber);

        // Call DisplayResult to show the final message
        DisplayResult(userName, squaredNumber);
    }

    // Function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt for user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt for user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to square a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
