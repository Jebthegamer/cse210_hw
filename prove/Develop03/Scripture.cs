public class Scripture
{
    private List<Verse> verses { get; set; }
    private Reference reference { get; set; }

    public void SetVerse(Verse verse)
    {
        verses.Add(verse);
    }
}