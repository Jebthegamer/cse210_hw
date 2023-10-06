public class Entry
{
    public string datePrompt { get; set; }
    public string response { get; set; }

    public Entry WriteEntry(string prompt)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine($"{dateText}: Prompt: {prompt}");
        Console.Write("> ");
        string response = Console.ReadLine();
        string datePrompt = $"Date: {dateText} - Prompt: {prompt}";
        Entry entry = new Entry
        {
            datePrompt = datePrompt,
            response = response
        };
        return entry;

    }

}