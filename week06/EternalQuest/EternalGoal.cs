public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent() => GetPoints();

    public override bool IsComplete() => false;

    public override string GetStatus() => "[∞]";

    public override string Serialize() => $"Eternal|{GetName()}|{GetDescription()}|{GetPoints()}";
}
