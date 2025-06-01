public class Word
{
    //Attributes
    private string _text;

    private bool _isHidden;


    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //method to hide the word
    public void Hide()
    {
        // set hidden to true
        _isHidden = true;
    }

    // implements the hide method
    public bool IsHidden()
    {
        return _isHidden;
    }

    //method to display the word or underscores depending on whether or not it's hidden
    public string GetDisplayWord()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }


}