public class Scripture
{
    private List<Verse> verses;
    private Reference reference;

    public void SetVerse(Verse verse)
    {
        verses.Add(verse);
    }
}