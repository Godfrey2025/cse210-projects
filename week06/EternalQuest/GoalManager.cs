public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int GetScore() => _score;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetName()} - {_goals[i].GetDescription()}");
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int points = _goals[goalIndex].RecordEvent();
            _score += points;
            Console.WriteLine($"You earned {points} points!");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                if (type == "Simple")
                {
                    var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.Parse(parts[4])) goal.RecordEvent();
                    _goals.Add(goal);
                }
                else if (type == "Eternal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (type == "Checklist")
                {
                    var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                                 int.Parse(parts[4]), int.Parse(parts[6]));
                    for (int j = 0; j < int.Parse(parts[5]); j++) goal.RecordEvent();
                    _goals.Add(goal);
                }
            }
        }
    }
}
