public class Journal
{
    public List<Entry> Entries { get; set; }
    public Journal()
    {
        Entries = new List<Entry>();        
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in Entries)
        {
            Console.WriteLine($"{entry.datePrompt}");
            Console.WriteLine($"{entry.response}");
            Console.WriteLine("");
        }
    }
    public void ReadFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int count = 0;
        Entry entry = new Entry();
        foreach (string line in lines)
        {
            // Every other line is a date+prompt and a response. Therefore, every other line a new entry must be made
            // and every other line it is added to the oldEntries journal.
            if (count % 2 == 0)
            {
                entry.SetDatePrompt(line);
            }
            else
            {
                entry.response = line;
            }
            if (count % 2 == 1)
            {
                Entries.Add(entry);
            }
            count ++;
        }
    }
    public void WriteFile(string fileName, Journal journal)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in Entries)
            {
                outputFile.WriteLine($"{entry.datePrompt}");
                outputFile.WriteLine($"{entry.response}");
            }
            foreach (Entry entry1 in journal.Entries)
            {
                outputFile.WriteLine($"{entry1.datePrompt}");
                outputFile.WriteLine($"{entry1.response}");
            }
        }
    }
    public Journal SaveFile(string fileName, Journal journal)
    {
        if(File.Exists(fileName))
        {
            ReadFile(fileName);
        }               
        // Notably clearing journal is not here because we are going to be using it.
        // Put the old entries back into the journal
        WriteFile(fileName, journal);
        // Next, we set the oldEntries to contain the new ones, as the loaded file now has both sets of entries.
        ReadFile(fileName);
        // Clear journal again; the entries are contained in oldEntries.
        journal = new Journal();
        return journal;
    }
}