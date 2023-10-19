public class Scripture
{
    private List<Word> _verses { get; set; }
    private Reference _reference { get; set; }

    public void SetVerse(Word verse)
    {
        _verses.Add(verse);
    }
    public void SetReference()
    {
        Console.WriteLine("");
    }
}