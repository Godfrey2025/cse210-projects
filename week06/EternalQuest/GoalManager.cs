public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void AddGoal(Goal goal) => goals.Add(goal);

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            score += goals[index].RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name} - {goals[i].Description}");
        }
    }

    public void DisplayScore() => Console.WriteLine($"Total Score: {score}");
}
