using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;

public class Verse
{
    // Attributes
    private int _verseNumber;
    private List<Word> _words;

    //Constructor
    public Verse(int verseNumber, string text)
    {
        // store the verse number
        _verseNumber = verseNumber;

        // create an empty list to hold the words in the verse
        _words = new List<Word>();

        //split the verse text into word objects
        string[] wordArray = text.Split(' ');

        // loop through the array and crate word objects for each word
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }

    } // End Constructor

    //Methods

    // method to display the formatted verse
    public string GetDisplayVerse()
    {
        string formattedVerse = "";
        foreach (Word word in _words)
        {
            formattedVerse += word.GetDisplayWord()+ " ";
        }

        return formattedVerse.Trim();
    }

    // method to hide random words
    public void HideRandomWords(int count)
    {
        Random random = new Random();

        // make a list of the visible words
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        // determine how many words are still available to be hidden
        int wordsToHide = Math.Min(count, visibleWords.Count);

        if (wordsToHide <= 0)
        {
            return;
        }

        // hide a word
        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }

    }

    // method to check if all of the words in this particular verse are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}