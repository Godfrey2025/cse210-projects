using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal g) => _goals.Add(g);
    public IReadOnlyList<Goal> Goals => _goals.AsReadOnly();
    public int Score => _score;

    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count) return;
        int pts = _goals[index].RecordEvent();
        _score += pts;
        Console.WriteLine($"You earned {pts} points.");
    }

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetStatus()}");
        }
    }

    public void Save(string filename)
    {
        using (var writer = new StreamWriter(filename))
        {
            writer.WriteLine($"SCORE|{_score}");
            foreach (var g in _goals)
                writer.WriteLine(g.Serialize());
        }
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("Save file not found.");
            return;
        }
        _goals.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            var parts = line.Split('|');
            if (parts[0] == "SCORE")
            {
                _score = int.Parse(parts[1]);
                continue;
            }
            var g = Goal.Deserialize(line);
            if (g != null) _goals.Add(g);
        }
    }
}
