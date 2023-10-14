public class Verse
{
    private List<int> _verseNumbers { get; set; }
    private List<string> _verseWords { get; set; }

    public void AddVerseNumbers(int verse)
    {
        _verseNumbers.Add(verse);
    }
    public void AddVerseWords(string verse)
    {
        _verseWords.Add(verse);
    }
}