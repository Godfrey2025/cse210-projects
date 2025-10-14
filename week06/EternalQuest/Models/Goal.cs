using System;

public abstract class Goal
{
    protected string _title;
    protected int _points;

    protected Goal(string title, int points)
    {
        _title = title;
        _points = points;
    }

    public string GetTitle() => _title;
    public int GetPoints() => _points;

    public abstract int RecordEvent(); // returns points awarded
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string Serialize();

    public static Goal Deserialize(string line)
    {
        // Format: TYPE|field1|field2|...
        var parts = line.Split('|');
        var type = parts[0];
        try
        {
            switch (type)
            {
                case "SIMPLE":
                    // SIMPLE|title|points|completed
                    return new SimpleGoal(parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
                case "ETERNAL":
                    // ETERNAL|title|points
                    return new EternalGoal(parts[1], int.Parse(parts[2]));
                case "CHECKLIST":
                    // CHECKLIST|title|points|current|target|bonus|completed
                    int points = int.Parse(parts[2]);
                    int current = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    bool completed = bool.Parse(parts[6]);
                    return new ChecklistGoal(parts[1], points, target, bonus, current, completed);
                default:
                    return null;
            }
        }
        catch
        {
            return null;
        }
    }
}
