// Word is where a lot of the logic goes in the program, as words are strings with a status of being hidden or not.
public class Word
{
    private bool _hidden {get; set;}
    private string _word { get; set; }

    // This is a function we call to set _hidden to be true or false. While it is always used to make it true, if the program
    // were to be expanded, being set to false could be a useful functionality. 
    public void SetHiddenStatus(bool hidden)
    {
        _hidden = hidden;
    }
    // This returns if a word is hidden or not.
    public bool GetHiddenStatus()
    {
        return _hidden;
    }
    // This can change the string value of a word. This is unused, as the constructor is used for this instead.
    // However, in a larger program this may be needed.
    public void SetWord(string verse)
    {
        _word = verse;
    }
    // This returns the value of _word if it isn't hidden. Otherwise, a word will be returned as underscores.
    public string GetWord()
    {
        // If the word is hidden, we need to return it in underscores instead of its actual written form.
        if (_hidden)
        {
            // Set a starting word; break _word into an array to find the length of _word.
            string word = "";
            char[] chars = _word.ToCharArray();
            int length = chars.Length;
            int i = 0;
            // While i, the counter, is less than the length of _word, then we add an underscore to word.
            while (i < length)
            {
                word += "_";
                i++;
            }
            return word;
        } 
        // If _word is not hidden, we simply return its value.
        else
        {
            return _word;
        }  
    }
    // Constructor for word.
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
}