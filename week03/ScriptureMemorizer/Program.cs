using System;
using System.Collections.Generic;   

//This is the Scripture Memorizer project
//It allows the user to memorize a scripture by hiding words randomly
class Program
{
    static void Main(string[] args)

    {
        // Create a reference scripture
        Reference reference = new Reference("Jeremiah", 29, 11);
        string text = "For I know the plans I have for you,” declares the Lord, “plans to prosper you and not to harm you, plans to give you hope and a future";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.AllWordsHidden()) // Check if all words are hidden
             {
                Console.WriteLine("All words are hidden. Well done!"); //
                break;
            }
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            // Hide 1 random word until all are hidden
            scripture.HideRandomWords(1);
        }
    }
}