using System;
using Develop02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        int selection = 0;
        while (selection != 5)
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            
            // Get user selection
            string userInput = Console.ReadLine();
            
            // try to parse user input to integer
            if (int.TryParse(userInput, out selection))
                switch (selection)
                {
                    // prompt user and create new entry with their response
                    case 1:
                        string promptText = promptGenerator.GeneratePrompt();
                        Console.WriteLine("");
                        Console.WriteLine(promptText);
                        Console.Write("> ");
                        string userText = Console.ReadLine();
                        
                        journal.CreateEntry(DateTime.Now.Date, promptText, userText);

                        break;
                    // display all entries in Journal
                    case 2:
                        journal.Display();
                        break;
                    // load journal entries saved to file given by user, and add to Journal
                    case 3:
                        Console.Write("Please enter the file name: ");
                        string fileName = Console.ReadLine();
                        string[] lines = System.IO.File.ReadAllLines(fileName);

                        foreach (string line in lines)
                        {
                            string[] parts = line.Split("|");

                            string dateLoaded = parts[0];
                            string promptLoaded = parts[1];
                            string textLoaded = parts[2];
                            journal.CreateEntry(promptLoaded, textLoaded);
                        }
                        
                        break;
                    // save journal entries to file given by user
                    case 4:
                        Console.WriteLine("Saving");
                        break;
                    // quit program
                    case 5:
                        Console.WriteLine("Enjoy your day!");
                        break;
                    // invalid user input
                    default:
                        Console.WriteLine("Invalid input. Please try again");
                        break;
                }
        }
    }
}