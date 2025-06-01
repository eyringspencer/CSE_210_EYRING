public class Scripture
{
    //Attributes
    private Reference _reference;

    private List<Verse> _verses;

    private int _currentVerseIndex;

    //Constructors

    // constructor for scriptures that only have one verse
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _verses = new List<Verse>();
        _currentVerseIndex = 0;

        //add a single verse object
        _verses.Add(new Verse(1, text));
    }

    // constructor for scriptures with multiple verses
    public Scripture(Reference reference, string[] verseTexts)
    {
        _reference = reference;
        _verses = new List<Verse>();
        _currentVerseIndex = 0;

        // create a verse object for each verse
        int verseNumber = 1;
        foreach (string verseText in verseTexts)
        {
            _verses.Add(new Verse(verseNumber, verseText));
            verseNumber++;
        }
    }

    //Methods

    // method to get the complete scripture display text
    public string GetDisplayScripture()
    {

        string result = _reference.GetDisplayReference() + "\n\n";

        foreach (Verse verse in _verses)
        {
            result += verse.GetDisplayVerse() + "\n\n";
        }

        return result.Trim();

    }

    // method to hide words verse by verse
    public void HideRandomWords(int count)
    {
        if (_currentVerseIndex >= _verses.Count)
        {
            return;
        }

        if (!_verses[_currentVerseIndex].IsCompletelyHidden())
        {
            _verses[_currentVerseIndex].HideRandomWords(count);
        }
        else
        {
            // move to the next verse
            _currentVerseIndex++;

            if (_currentVerseIndex < _verses.Count)
            {
                _verses[_currentVerseIndex].HideRandomWords(count);
            }
        }
    }


    // method to check if the entire scripture is hidden
    public bool IsCompletelyHidden()
    {
        foreach (Verse verse in _verses)
        {
            if (!verse.IsCompletelyHidden())
            {
                return false;
            }
        }
        return true;
    }
}