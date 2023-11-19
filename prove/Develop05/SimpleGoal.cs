public class SimpleGoal : EternalGoal
{
    private bool _completed = false;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public SimpleGoal(string name, string description, int points, bool completion) : base(name, description, points)
    {
        _completed = completion;
    }
    public override void UpdateSaveString()
    {
        SaveString = $"SimpleGoal,{GoalName},{GoalDescription},{Points},{_completed}";
    }
    public override void DisplayGoal(int i)
    {
        if (_completed)
        {
            Console.WriteLine($"{i}. [X] {GoalName} ({GoalDescription})");
        }
        else
        {
            Console.WriteLine($"{i}. [ ] {GoalName} ({GoalDescription})");
        }
    }
    public override int CompleteGoal()
    {
        if (_completed)
        {
            Console.WriteLine("You have already completed this goal.");
            return 0;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have scored {Points} points!");
            _completed = true;
            UpdateSaveString();
            return Points;
        }

    }
    public override SimpleGoal DecodeSaveString(string saveString)
    {
        string[] pieces = saveString.Split(",");
        SimpleGoal simpleGoal = new(pieces[1], pieces[2], int.Parse(pieces[3]), bool.Parse(pieces[4]));
        return simpleGoal;
    }
}