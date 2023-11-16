public class EternalGoal
{
    public string GoalName { get; set; }
    public string GoalDescription { get; set; }
    public int Points { get; set; }
    public string SaveString { get; set; }
    public EternalGoal(string name, string description, int points)
    {
        GoalName = name;
        GoalDescription = description;
        Points = points;
        UpdateSaveString();
    }
    public virtual void UpdateSaveString()
    {
        SaveString = $"EternalGoal:{GoalName},{GoalDescription},{Points}";
    }
    public virtual void DisplayGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GoalName} ({GoalDescription})");
    }
    public virtual int CompleteGoal()
    {
        Console.WriteLine($"Congratulations! You have scored {Points} points!");
        return Points;
    }
}