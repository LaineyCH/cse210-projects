namespace Develop03;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    private int _numberVerses = 1;

    // CONSTRUCTORS
    
    // constructor for a single verse
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = startVerse;
    }
    
    // constructor for multiple consecutive verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = startVerse;
        _verseEnd = endVerse;
        _numberVerses = _verseEnd - _verseStart + 1;
    }
    
    // GETTERS & SETTERS
    public int GetStartVerse() => _verseStart;

    // METHODS
    public void Display()
    {
        // display the reference as a string
        if (_numberVerses > 1)
        {
            Console.Write($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
        }
        else
        {
            Console.Write($"{_book} {_chapter}:{_verseStart}");
        }
        
    }
}