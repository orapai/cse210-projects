using System;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();

    public Journal()
    {
    }
    public void Display()
    {
        foreach (Entry entry in _journal)
        {
            Console.WriteLine($"Date: {entry._date} - {entry._prompt}");
            Console.WriteLine(entry._entry);
        }
    }
    public List<string> SaveEntries()
    {
        List<string> _entries = new List<string>();
        foreach (Entry entry in _journal)
        {
            string journalEntry = "";
            journalEntry = $"Date: {entry._date} - {entry._prompt}" + "\n" + entry._entry;
            _entries.Add(journalEntry);
        }
        return _entries;
    }
}