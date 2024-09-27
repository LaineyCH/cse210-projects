namespace Develop02;

public class Entry
{
    private DateTime _entryDate;
    private string _promptText;
    private string _userText;
    
    public DateTime EntryDate
    {
        set
        {
            // validate that date is a DateTime object
            if (value.Kind != DateTimeKind.Local)
            {
                throw new ArgumentException("Entry date must be Local.");
            }
            else
            {
                _entryDate = value;
            }
        }
    }

    public string PromptText
    {
        set
        {
            // Validate string is not null
            if (value == null)
            {
                throw new ArgumentException("PromptText cannot be null.");
            }
            else
            {
                _promptText = value;
            }
        }
    }

    public string UserText
    {
        set
        {
            // Validate string is not null
            if (value == null)
            {
                throw new ArgumentException("UserText cannot be null.");
            }
            else
            {
                _userText = value;
            }
        }
    }
    
    // Constructor
    public Entry(DateTime entryDate, string promptText, string userText)
    {
        // Use the property setters to enforce validation
        EntryDate = entryDate;
        PromptText = promptText;
        UserText = userText;
    }

    public void Display()
    {
        string date = _entryDate.ToString("dd/MM/yyyy");
        Console.WriteLine("");
        Console.WriteLine($"{date} - {_promptText}");
        Console.WriteLine($"{_userText}");
    }
    
    public string GetEntryString()
    {
        string date = _entryDate.ToString("dd/MM/yyyy");
        string entryString = $"\"{date}\",\"{_promptText}\",\"{_userText}\"";
        return entryString;
    }
    
}