public class Reference
{
    private string _book { get; set; }
    private int _chapterNumber { get; set; }
    private int _verseNumber { get; set; }

    public void SetBook(string i)
    {
        _book = i;
    }
    public void SetChapterNumber(int i)
    {
        _chapterNumber = i;
    }
    public void SetVerseNumber(int i)
    {
        _verseNumber = i;
    }
}