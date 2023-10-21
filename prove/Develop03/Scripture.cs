using System.Data;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

public class Scripture
{
    // A scripture contains two pieces of information, the words of the verse and the reference of it.
    // A verse is nothing more than a list of words. As my verses are stored as strings, I named the property "_verses"
    // instead of "_verse" because there is effectively no difference between them. 
    private List<Word> _verses { get; set; }
    private Reference _reference { get; set; }

    // This adds words to a verse. In no place in my program do I need to remove words from a verse, but instead modify them.
    public void AddToVerse(Word verse)
    {
        _verses.Add(verse);
    }
    // This is a simple getter for the verse(s).
    public List<Word> GetVerse()
    {
        return _verses;
    }
    // This sets a reference.
    public void SetReference(Reference reference)
    {
        _reference = reference;
    }
    // This returns the reference.
    public Reference GetReference()
    {
        return _reference;
    }
    // This is the constructor I used for the scripture. A scripture needs a verse and a reference.
    // The verse is a string which can be broken up into multiple words.
    public Scripture(string verse, string reference)
    {
        // First, break down the verse(s) into individual words, then store them as a list of words.
        string[] verseThing = verse.Split(" ");
        List<Word> words = new List<Word>();
        foreach (string term in verseThing)
        {
            Word word = new Word(term);
            words.Add(word);
        }
        // Finally, set _verses to be the same as words.
        _verses = words;
        // Create a new reference using the input string.
        Reference reference1 = new Reference(reference);
        _reference = reference1;
    }
    // This is how we hide words from a scripture.
    // This may have been included as a method for words, but this functions as SetHiddenStatus for the list of words contained
    // in _verses, as well as having broader applications for the program as a whole. 
    public bool HideWords()
    {
        // Determine if anything needs to be set to hidden. If not, then the loop should be told to end.
        bool setHidden = false;
        // Check each individual word
        foreach (Word word in _verses)
        {
            // If one word is not hidden, then allow the program to hide words.
            if (word.GetHiddenStatus() == false)
            {
                setHidden = true;
            }
        }
        // If we are hiding words, perform this operation.
        if (setHidden)
        {
            // Randomly select a number of words to hide, then create a list of integers.
            var random = new Random();
            int hiding = random.Next(1,5);
            List<int> ints = new List<int>();
            // Select a random number for each random instance of word-hiding to hide. Then decrease the value of hiding until it is 0
            while (hiding > 0)
            {
                ints.Add(random.Next(_verses.Count));
                hiding--;
            }
            // Set a counter and a boolean to determine if we need to end the loop early.
            int count = 0;
            bool end = false;
            while (count < ints.Count)
            {
                // If it's been detected that there are no words to hide, then the loop should end early.
                if (end)
                {
                    break;
                }
                // Check if the word we have selected to hide is already hidden.
                bool hidden = _verses[ints[count]].GetHiddenStatus();
                if (hidden == false)
                {
                    // If it isn't, then hide it and increase the counter for words we have hidden.
                    _verses[ints[count]].SetHiddenStatus(true);
                    count++;
                }
                // Otherwise, we'll need to hide another word. This segment does that.
                else
                {
                    // However, if the entire list is hidden, this will create an infinite loop.
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
                    // If the loop is continuing, then we need to change the value of the integer that hides the word. This continues
                    // until we find a word that can be hidden. 
                    // For longer verses, logic could be implemented that could detect the exact amount of words remaining, as well as 
                    // their location, and set this to one of those values, but for the sake of this program this is largely unnecessary.
                    ints[count] = random.Next(_verses.Count);
                }
            }
        }
        // If we have hidden no words, then we need to send an output that none were hidden to end the program.
        return setHidden;
    }
    public void DisplayScripture()
    {
        Console.WriteLine($"{_reference.GetReference()}");
        bool first = true;
        foreach (Word verse in _verses)
        {
            string word = verse.GetWord();
            if (first)
            {
                Console.Write($"{word}");
                first = false;
            }
            else
            {
                Console.Write($" {word}");
            }
                
        }
        Console.WriteLine("");
    }
    
}