using System.Runtime.InteropServices.JavaScript;
using System;
using System.Collections.Generic;

namespace Develop02;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void CreateEntry(DateTime entryDate, string promptText, string userText)
    {
        Entry entry = new Entry(entryDate, promptText, userText);
        
        _entries.Add(entry);
    }

    public void Display()
    {
        Console.WriteLine("");
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
    
}