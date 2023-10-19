public class Word
{
    private bool _hidden {get; set;}
    private string _word { get; set; }

    public void SetHiddenStatus(bool hidden)
    {
        _hidden = hidden;
    }
    public void SetWord(string verse)
    {
        _word = verse;
    }
}