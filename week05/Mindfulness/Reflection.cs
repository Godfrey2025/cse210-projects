using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you overcame a challenge.",
        "Think of a time you showed courage."
    };

    private List<string> questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?"
    };

    public ReflectionActivity()
    {
        name = "Reflection";
        description = "Reflect on your strengths and past experiences.";
    }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Pause(3);

        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine(questions[rand.Next(questions.Count)]);
            Pause(5);
            elapsed += 5;
        }

        End();
    }
}
