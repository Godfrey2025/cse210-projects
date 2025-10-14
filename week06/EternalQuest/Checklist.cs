public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        this.targetCount = targetCount;
        this.bonus = bonus;
        currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            return currentCount == targetCount ? Points + bonus : Points;
        }
        return 0;
    }

    public override string GetStatus() => $"Completed {currentCount}/{targetCount}";
    public override bool IsComplete() => currentCount >= targetCount;
}
