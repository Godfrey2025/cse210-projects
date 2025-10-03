using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "List people you appreciate.",
        "List things you're good at.",
        "List moments that made you smile."
    };

    public ListingActivity()
    {
        name = "Listing";
        description = "Focus on positive things by listing them.";
    }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Console.WriteLine("Start listing in:");
        Pause(3);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) items.Add(input);
        }

        Console.WriteLine($"You listed {items.Count} items!");
        End();
    }
}
