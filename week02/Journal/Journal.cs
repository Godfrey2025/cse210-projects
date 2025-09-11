using System;
using System.Collections.Generic;
using System.IO;

public class Journal

{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, response);
        _entries.Add(newEntry);
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(" - ");
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[1].Trim(), parts[2]);
                // If Entry has a Date property, set it here
                // entry.Date = DateTime.Parse(parts[0]);
                _entries.Add(entry);
            }
        }
    }
} 