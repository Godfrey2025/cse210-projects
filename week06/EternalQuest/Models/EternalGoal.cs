using System;

public class EternalGoal : Goal
{
    public EternalGoal(string title, int points) : base(title, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete() => false;

    public override string GetStatus() => $"[~] {_title}";

    public override string Serialize() => $"ETERNAL|{_title}|{_points}";
}
