public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var rand = new Random(); 
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();  

        for (int i = 0; i < count && visibleWords.Count > 0; i++)  // Ensure we don't try to hide more words than are visible
        {
            var wordToHide = visibleWords[rand.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }

    public bool AllWordsHidden() => _words.All(w => w.IsHidden);  

    public string GetDisplayText() // Returns the scripture with hidden words as underscores
    {
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference}\n{text}";        // Format: "Book Chapter:Verse Text"
    }
}

