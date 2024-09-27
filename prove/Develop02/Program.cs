using Develop02;

// To exceed requirements, I have made saving and loading possible for .csv files (they can be opened in Excel),
// I have used DateTime objects (converting to string and back), and I have implemented validation of user inputs.
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
            Console.Write("What would you like to do? ");
            
            // Get user selection
            string userInput = Console.ReadLine();
            
            // try to parse user input to integer
            if (int.TryParse(userInput, out selection))
                switch (selection)
                {
                    case 1:
                        // prompt user and create new entry with their response
                        string promptText = promptGenerator.GeneratePrompt();
                        Console.WriteLine("");
                        Console.WriteLine(promptText);
                        Console.Write("> ");
                        string userText = Console.ReadLine();
                        journal.CreateEntry(DateTime.Now.Date, promptText, userText);
                        break;
                    case 2:
                        // display all entries in Journal
                        journal.Display();
                        break;
                    case 3:
                        // load journal entries from a file given by user
                        journal.LoadFromFile();
                        break;
                    case 4:
                        // save journal entries to file given by user
                        Console.Write("Please enter the file name: ");
                        string saveFileName = Console.ReadLine();
                        journal.SaveToFile(saveFileName);
                        break;
                    case 5:
                        // quit program
                        Console.WriteLine("Thank you for using the Journal Program.");
                        break;
                    default:
                        // invalid user input
                        Console.WriteLine("Invalid input. Please try again");
                        break;
                }
        }
    }
}