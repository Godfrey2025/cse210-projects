public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public virtual void Start()
    {
        Console.WriteLine($"Starting {name} Activity: {description}");
        Console.Write("Enter duration in seconds: ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out duration) || duration <= 0)
        {
            Console.WriteLine("Invalid duration entered. Using default 30 seconds.");
            duration = 30;
        }
    }

    protected void Pause(int seconds)
    {
        // Simple spinner animation during pauses so the user sees activity
        var spinner = new[] { '|', '/', '-', '\\' };
        int framesPerSecond = 8; // smooth but not too fast
        int totalFrames = Math.Max(1, seconds * framesPerSecond);

        for (int i = 0; i < totalFrames; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            System.Threading.Thread.Sleep(1000 / framesPerSecond);
            Console.Write('\b'); // erase spinner char
        }
    }

    // Countdown helper that shows numbers (3,2,1...) before starting an activity
    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write('\b');
            Console.Write(' ');
            Console.Write('\b');
        }
        Console.WriteLine();
    }

    public virtual void End()
    {
        Console.WriteLine($"Good job! You completed the {name} activity for {duration} seconds.");
    }

    public abstract void Run();
}