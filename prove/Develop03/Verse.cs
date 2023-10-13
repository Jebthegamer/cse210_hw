public class Verse
{
    private List<int> _verseNumbers;
    private List<string> _verseWords;

    public void AddVerseNumbers(int verse)
    {
        _verseNumbers.Add(verse);
    }
    public void AddVerseWords(string verse)
    {
        _verseWords.Add(verse);
    }
}