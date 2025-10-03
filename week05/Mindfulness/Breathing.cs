using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        name = "Breathing";
        description = "Relax by breathing in and out slowly. Focus on your breath.";
    }

    public override void Run()
    {
        Run();
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            Pause(4);
            elapsed += 4;
            if (elapsed >= duration) break;
            Console.WriteLine("Breathe out...");
            Pause(6);
            elapsed += 6;
        }
        End();
    }
}
