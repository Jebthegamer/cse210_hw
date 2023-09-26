public class Resume
{
    public string Name;
    public List<Job> Jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {Name}");
        foreach (Job j in Jobs)
        {
            j.Display();
        }
    }
}