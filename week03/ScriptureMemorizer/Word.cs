public class Word
{
    private string _text; // The actual word text
    private bool _isHidden; // Indicates if the word is hidden

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

public void Hide() => _isHidden = true;//

    public bool IsHidden => _isHidden;

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}


