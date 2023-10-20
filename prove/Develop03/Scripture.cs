using System.Data;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

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
    public Scripture(string verse, string reference)
    {
        string[] verseThing = verse.Split(" ");
        List<Word> words = new List<Word>();
        foreach (string term in verseThing)
        {
            Word word = new Word(term);
            words.Add(word);
        }
        _verses = words;
        Reference reference1 = new Reference(reference);
        _reference = reference1;
    }
    public bool HideScriptures()
    {
        // Determine if anything needs to be set to hidden. If not, then the loop should be told to end.
        bool setHidden = false;
        foreach (Word word in _verses)
        {
            if (word.GetHiddenStatus() == false)
            {
                setHidden = true;
            }
        }
        if (setHidden)
        {
            var random = new Random();
            int hiding = random.Next(5);
            List<int> ints = new List<int>();
            while (hiding > 0)
            {
                ints.Add(random.Next(_verses.Count));
                hiding--;
            }
            int count = 0;
            bool end = false;
            while (count < ints.Count)
            {
                // If it's been detected that there are no words to hide, then the loop should end. 
                if (end)
                {
                    break;
                }
                bool hidden = _verses[ints[count]].GetHiddenStatus();
                if (hidden == false)
                {
                    _verses[ints[count]].SetHiddenStatus(true);
                }
                else
                {
                    // If the entire list is false, this will create an infinite loop.
                    // Therefore, testing is needed.
                    bool test = false;
                    // Check each word in _verses
                    foreach (Word word in _verses)
                    {
                        // If one word is not hidden, then more words can be hidden. Therefore, the loop doesn't need to end.
                        if (word.GetHiddenStatus() == false)
                        {
                            test = true;
                        }
                    }
                    // If no words are able to be hidden, then the loop should end.
                    if (test == false)
                    {
                        end = true;
                        break;
                    }
                    ints[count] = random.Next(_verses.Count);
                }
            }
        }
        return setHidden;
    }
    
}