namespace Develop03;
using System;

public class Verse
{
    private List<Word> _words;
    private int _wordsNotHidden;
    
    // CONSTRUCTOR
    public Verse(string verse)
    {
        // parse the string and create a list of the individual words
        string[] verseWords = verse.Split(' ');
        _words = new List<Word>(verseWords.Length);
        foreach (string w in verseWords)
        {
            _words.Add(new Word(w));
        }
        _wordsNotHidden = _words.Count;
    }

    // PROPERTY
    public bool IsHidden => _wordsNotHidden == 0;

    // METHODS
    public void Display()
    {
        foreach (Word w in _words)
        {
            w.Display();
        }
    }

    public void HideWords()
    {
        int numToRemove = 0;
        Random random = new Random();
        
        // set a different number of words to remove dependent on how many words are shown
        if (_wordsNotHidden > 25)
        {
            numToRemove = random.Next(3, 8);
        }
        else if (_wordsNotHidden > 15)
        {
            numToRemove = random.Next(3, 5);
        }
        else if (_wordsNotHidden > 5)
        {
            numToRemove = random.Next(1, 3);
        }
        else if (_wordsNotHidden > 1)
        {
            numToRemove = _wordsNotHidden;
        }

        // if there are still words shown, remove words at random indexes. If the word at the random index was already
        // hidden, select the next word, continuing until an unhidden word is found (looping back to index 0 when the
        // end of the list is reached.
        if (_wordsNotHidden > 0)
        {
            for (int i = 0; i < numToRemove; i++)
            {
                int randomIndex = random.Next(0, _wordsNotHidden);
                while (_words[randomIndex].Hidden())
                {
                    randomIndex++;
                    if (randomIndex == _words.Count)
                    {
                        randomIndex = 0;
                    }
                }

                _words[randomIndex].Hide();
            }
            // subtract the number of words removed from the count of unhidden words.
            _wordsNotHidden -= numToRemove;
        }
    }

}