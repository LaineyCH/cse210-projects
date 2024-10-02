namespace Develop03;

public class Word
{
    private string _chars;
    private bool _hidden = false;

    // CONSTRUCTOR
    public Word(string chars)
    {
        _chars = chars;
    }
    
    // GETTERS & SETTERS
    public string GetWord() => _chars;
    public void SetWord(string word) => _chars = word;
    public bool Hidden() => _hidden;

    // METHODS
    public void Display()
    {
        // add space before word
        Console.Write(" ");
        // if the word is hidden, replace each character with a "_"
        if (_hidden)
        {
            int wordLength = _chars.Length;
            for (int i = 0; i < wordLength; i++)
            {
                Console.Write("_");
            }
        }
        // if the word is not hidden, display its characters
        else
        {
            Console.Write(_chars);
        }
    }
    
    public void Hide()
    {
        // hide the word
        _hidden = true;
    }
}