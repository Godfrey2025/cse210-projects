public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public virtual void Start()
    {
        Console.WriteLine($"Starting {name} Activity: {description}");
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    protected void Pause(int seconds)
    {
        System.Threading.Thread.Sleep(seconds * 1000);
    }

    public virtual void End()
    {
        Console.WriteLine($"Good job! You completed the {name} activity for {duration} seconds.");
    }

    public abstract void Run();
}