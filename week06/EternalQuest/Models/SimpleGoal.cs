using System;

public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string title, int points, bool completed = false) : base(title, points)
    {
        _completed = completed;
    }

    public override int RecordEvent()
    {
        if (_completed) return 0;
        _completed = true;
        return _points;
    }

    public override bool IsComplete() => _completed;

    public override string GetStatus() => _completed ? $"[X] {_title}" : $"[ ] {_title}";

    public override string Serialize() => $"SIMPLE|{_title}|{_points}|{_completed}";
}
