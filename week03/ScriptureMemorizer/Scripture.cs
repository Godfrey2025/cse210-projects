using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _rand = new Random();

    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var w in text.Split(' '))
            _words.Add(new Word(w));
    }

    public void HideWords(int count)
    {
        var notHidden = new List<int>();
        for (int i = 0; i < _words.Count; i++)
            if (!_words[i].IsHidden())
                notHidden.Add(i);
        for (int i = 0; i < count && notHidden.Count > 0; i++)
        {
            int idx = _rand.Next(notHidden.Count);
            _words[notHidden[idx]].Hide();
            notHidden.RemoveAt(idx);
        }
    }

    public bool AllHidden()
    {
        foreach (var w in _words)
            if (!w.IsHidden()) return false;
        return true;
    }

    public string GetText()
    {
        var wordDisplays = new List<string>();
        foreach (var w in _words)
            wordDisplays.Add(w.GetDisplayText());
        return string.Join(" ", wordDisplays);
    }

    public string GetReference()
    {
        return _reference.GetDisplayText();
    }
}