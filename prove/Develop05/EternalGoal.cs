public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points)
    {
        GoalName = name;
        GoalDescription = description;
        Points = points;
        UpdateSaveString();
    }
    public override void UpdateSaveString()
    {
        SaveString = $"EternalGoal,{GoalName},{GoalDescription},{Points}";
    }
    public override EternalGoal DecodeSaveString(string saveString)
    {
        string[] pieces = saveString.Split(",");
        EternalGoal eternalGoal = new(pieces[1], pieces[2], int.Parse(pieces[3]));
        return eternalGoal;
    }
    public override int CompleteGoal()
    {
        Console.WriteLine($"Congratulations! You have scored {Points} points!");
        Celebration();
        return Points;
    }
}