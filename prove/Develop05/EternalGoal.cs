using System.Net.NetworkInformation;
using System.Security.Cryptography;

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
    // Update the string used for saving information.
    public virtual void UpdateSaveString()
    {
        SaveString = $"EternalGoal,{GoalName},{GoalDescription},{Points}";
    }
    public virtual void DisplayGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GoalName} ({GoalDescription})");
    }
    public virtual int CompleteGoal()
    {
        Console.WriteLine($"Congratulations! You have scored {Points} points!");
        Celebration();
        return Points;
    }
    public string GetSaveString()
    {
        return SaveString;
    }
    // Input a string and use it to get the goal's information.
    public virtual EternalGoal DecodeSaveString(string saveString)
    {
        string[] pieces = saveString.Split(",");
        EternalGoal eternalGoal = new(pieces[1], pieces[2], int.Parse(pieces[3]));
        return eternalGoal;
    }
    // An animation, which exceeds requirements by adding another visual aspect to the goals.
    protected void Celebration()
    {
        int counter = 0;
        while (counter < 10)
        {
            Console.Write("'0'");
            Thread.Sleep(200);
            int count = 0;
            while (count < 3)
            {
                Console.Write("\b");
                count++;
            }
            Console.Write("   ");
            Console.Write("\b");
            Console.Write("\b");
            Console.Write("\b");
            Console.Write(",0,");
            Thread.Sleep(200);
            count = 0;
            while (count < 3)
            {
                Console.Write("\b");
                count++;
            }
            Console.Write("   ");
            Console.Write("\b");
            Console.Write("\b");
            Console.Write("\b");
            counter++;
        }
    }
}