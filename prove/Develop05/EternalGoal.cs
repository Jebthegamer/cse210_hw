public class EternalGoal
{
    protected string GoalName { get; set; }
    protected string GoalDescription { get; set; }
    protected int Points { get; set; }
    protected string SaveString { get; set; }
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