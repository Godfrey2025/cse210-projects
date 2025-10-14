using System;

public class ChecklistGoal : Goal
{
    private int _current;
    private int _target;
    private int _bonus;
    private bool _completed;

    // Accept current count so we can restore state from saved file
    public ChecklistGoal(string title, int points, int target, int bonus, int current = 0, bool completed = false) : base(title, points)
    {
        _target = target;
        _bonus = bonus;
        _current = current;
        _completed = completed;
    }

    public override int RecordEvent()
    {
        if (_completed) return 0;
        _current++;
        int awarded = _points;
        if (_current >= _target)
        {
            _completed = true;
            awarded += _bonus;
        }
        return awarded;
    }

    public override bool IsComplete() => _completed;

    public override string GetStatus() => _completed ? $"[X] {_title} (Completed {_current}/{_target})" : $"[ ] {_title} (Completed {_current}/{_target})";

    public override string Serialize() => $"CHECKLIST|{_title}|{_points}|{_current}|{_target}|{_bonus}|{_completed}";
}
