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

    public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                sw.WriteLine(e.GetEntryString());
            }
        }
    }

    public void LoadFromFile()
    {
        string readFileName = "";
        bool fileOpened = false;
        while (!fileOpened)
        {
            Console.Write("Please enter the file name: ");
            readFileName = Console.ReadLine();
            try
            {
                using (StreamReader sr = new StreamReader(readFileName))
                {
                    _entries.Clear();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(",");
                        string dateLoaded = parts[0].Trim('"');
                        string promptLoaded = parts[1].Trim('"');
                        string textLoaded = parts[2].Trim('"');
                        // parse date as Local DateTime
                        DateTime parsedDate = DateTime.Parse(dateLoaded).ToLocalTime();
                        CreateEntry(parsedDate, promptLoaded, textLoaded);
                    }
                    fileOpened = true;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found, please try again.");
            }
        }
    }
}