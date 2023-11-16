public class ChecklistGoal : EternalGoal
{
    public int Completed { get; set; }
    public int TotalNeeded { get; set; }
    public int BonusPoints { get; set; }
    public ChecklistGoal(string name, string description, int points, int total, int bonus) : base(name, description, points)
    {
        Completed = 0;
        TotalNeeded = total;
        BonusPoints = bonus;
        UpdateSaveString();
    }
    public override int CompleteGoal()
    {
        if (Completed < TotalNeeded)
        {
            Completed++;
            Console.WriteLine($"Congratulations! You have scored {Points} points!");
            return Points;
        }
        else
        {
            Console.WriteLine("You have already completed this goal.");
            return 0;
        }
    }
    public override void DisplayGoal(int i)
    {
        if (Completed < TotalNeeded)
        {
            Console.WriteLine($"{i}. [ ] {GoalName} ({GoalDescription}) -- Currently Completed: {Completed}/{TotalNeeded}");
        }
        else
        {
            Console.WriteLine($"{i}. [X] {GoalName} ({GoalDescription}) -- Currently Completed: {Completed}/{TotalNeeded}");
        }
    }
    public override void UpdateSaveString()
    {
        SaveString = $"ChecklistGoal:{GoalName},{GoalDescription},{Points},{BonusPoints},{TotalNeeded},{Completed}";
    }
}