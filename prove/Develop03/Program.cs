using System;
using System.Diagnostics.Contracts;
class Program
{
    static void Main(string[] args)
    {
        Scripture initializer = new Scripture();
        string fileName = "Scriptures.txt";
        List<Scripture> scriptures = initializer.ReadFile(fileName);
        foreach (Scripture scripture in scriptures)
        {
            Reference reference = scripture.GetReference();
            Console.WriteLine($"{reference}");
            List<Word> verseWords = scripture.GetVerse();
            foreach (Word verse in verseWords)
            {
                string word = verse.GetWord();
                Console.WriteLine($"{word}");
            }
            
        }
    }
}