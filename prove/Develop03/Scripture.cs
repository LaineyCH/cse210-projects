namespace Develop03;
using System;

public class Scripture
{
    private Reference _reference;
    private List<Verse> _verses;

    // CONSTRUCTOR
    public Scripture(Reference reference, List<Verse> verses)
    {
        _reference = reference;
        _verses = verses;
    }
    
    // GETTERS & SETTERS
    public Reference GetReference => _reference;
    public List<Verse> GetWords => _verses;
    public bool AllVersesHidden => _verses.All(verse => verse.IsHidden);

    
    // METHODS
    public void Display()
    {
        // display the referece
        _reference.Display();
        // retrieve the number of the first/only verse
        int verseNum = _reference.GetStartVerse();
        // go through the list of verses and display each one, with the verse number ahead of it.
        foreach (Verse v in _verses)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write($"{verseNum}.");
            v.Display();
            verseNum++;
        }
    }

    public void Memorise()
    {
        Console.Clear();
        while (true)
        {
            // display the scripture and the message asking the user for input
            Display();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Type 'quit' to exit, or press Enter to continue: ");
    
            // capture user input
            string userInput = Console.ReadLine();

            // if the user typed quit, leave a thank you messag eand end the program
            if (userInput.ToLower() == "quit" || userInput.ToLower() == "q")
            {
                Console.Clear();
                Console.WriteLine("Thank you for using the Scripture Mastery Program");
                break;
            }
            // if the user pressed enter clear the console and hide words in the verses
            // end the program as soon as all verses are completely hidden
            if (string.IsNullOrEmpty(userInput))
            {
                Console.Clear();
                foreach (Verse v in _verses)
                {
                    v.HideWords();
                }
                if (AllVersesHidden)
                {
                    break;
                }
            }
        }
    }
    
}