public class Scripture
{
    private List<Word> _verses { get; set; }
    private Reference _reference { get; set; }

    public void AddToVerse(Word verse)
    {
        _verses.Add(verse);
    }
    public List<Word> GetVerse()
    {
        return _verses;
    }
    public void SetReference(Reference reference)
    {
        _reference = reference;
    }
    public Reference GetReference()
    {
        return _reference;
    }
    public List<Scripture> ReadFile(string fileName)
    {
        Scripture scripture = new Scripture();
        var scriptureList = new List<Scripture>();
        string[] lines = File.ReadAllLines(fileName);
        int count = 0;
        int totalScriptures = 0;
        foreach (string line in lines)
        {
            if (count == 0)
            {
                Scripture readScripture = new Scripture();
                Reference lineReference = new Reference("line");
                scripture.SetReference(lineReference);
            }
            else if (count == 1)
            {
                string[] newLine = line.Split(" ");
                foreach (string word in newLine)
                {
                    Word verseWord = new Word(word);
                    scriptureList[totalScriptures].AddToVerse(verseWord);
                }
                count = 0;
                totalScriptures ++;
            }
        }
        return scriptureList;
    }
}