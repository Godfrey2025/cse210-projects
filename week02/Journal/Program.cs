using System;

class Program
{

    static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("1. Write a new entry\n2. Display journal\n3. Save journal\n4. Load journal\n5. Quit");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompts[new Random().Next(prompts.Count)];
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    journal.AddEntry(prompt, response);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
            }
        }
    }
}







