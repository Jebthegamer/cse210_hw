public class Word
{
    private bool _hidden {get; set;}
    private string _word { get; set; }

    public void SetHiddenStatus(bool hidden)
    {
        _hidden = hidden;
    }
    public bool GetHiddenStatus()
    {
        return _hidden;
    }
    public void SetWord(string verse)
    {
        _word = verse;
    }
    public string GetWord()
    {
        if (_hidden)
        {
            string word = "";
            char[] chars = _word.ToCharArray();
            int length = chars.Length;
            int i = 0;
            while (i < length)
            {
                word += "_";
                i++;
            }
            return word;
        } 
        else
        {
            return _word;
        }  
    }
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
}