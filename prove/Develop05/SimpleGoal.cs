public class SimpleGoal : EternalGoal
{
    private bool completed = false;
    public SimpleGoal(string name, string description, int points) : base(name,description,points)
    {

    }
    public override void UpdateSaveString()
    {
        SaveString = $"SimpleGoal:{GoalName},{GoalDescription},{Points},{completed}";
    }
    public override void DisplayGoal(int i)
    {
        if (completed)
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
        if (completed)
        {
            Console.WriteLine("You have already completed this goal.");
            return 0;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have scored {Points} points!");
            completed = true;
            return Points;
        }
    }
}