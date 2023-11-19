public class ChecklistGoal : EternalGoal
{
    private int Completed { get; set; }
    private int TotalNeeded { get; set; }
    private int BonusPoints { get; set; }
    public ChecklistGoal(string name, string description, int points, int total, int bonus) : base(name, description, points)
    {
        Completed = 0;
        TotalNeeded = total;
        BonusPoints = bonus;
        UpdateSaveString();
    }
    public ChecklistGoal(string name, string description, int points, int total, int bonus, int completed) : base(name, description, points)
    {
        Completed = completed;
        TotalNeeded = total;
        BonusPoints = bonus;
        UpdateSaveString();
    }
    public override int CompleteGoal()
    {
        if (Completed < TotalNeeded)
        {
            Completed++;
            int points = 0;
            points += Points;
            Console.WriteLine($"Congratulations! You have scored {Points} points!");
            if (Completed == TotalNeeded)
            {
                points += BonusPoints;
            }
            UpdateSaveString();
            return points;
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
        SaveString = $"ChecklistGoal,{GoalName},{GoalDescription},{Points},{BonusPoints},{TotalNeeded},{Completed}";
    }
    private void SetBonusPoints(int i)
    {
        BonusPoints = i;
    }
    private void SetTotalNeeded(int i)
    {
        TotalNeeded = i;
    }
    private void SetCompleted(int i)
    {
        Completed = i;
    }
    public override ChecklistGoal DecodeSaveString(string saveString)
    {
        string[] pieces = saveString.Split(",");
        ChecklistGoal checklistGoal = new(pieces[1], pieces[2], int.Parse(pieces[3]), int.Parse(pieces[4]), int.Parse(pieces[5]), int.Parse(pieces[6]));
        return checklistGoal;
    }
}