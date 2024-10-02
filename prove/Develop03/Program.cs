using System;
using Develop03;

// I exceeded the requirements by including a library of scriptures / Scripture Book, the user can select
// which scripture they wish to memorise. I also added a class for verses.
class Program
{
    static void Main(string[] args)
    {
        // create scripture book
        ScriptureBook book = new ScriptureBook();
        
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Scripture Mastery Program!");
        Console.WriteLine("");
        Console.WriteLine("Please select a scripture to memorise");

        // display selection of scriptures for user to choose from
        book.DisplayReferenceList();
        Console.Write("> ");
        
        // get user selection
        string userInput = Console.ReadLine();
        int selectionIndex = int.Parse(userInput) - 1;
        
        // start memorise method on selected scripture
        book.GetSelectedScripture(selectionIndex).Memorise();
    }
}