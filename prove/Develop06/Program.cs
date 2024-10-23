using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine($"You have 0 points.");
        int selection = 0;
        while (selection != 6)
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            // Get user selection
            string userInput = Console.ReadLine();
            
            // try to parse user input to integer
            if (int.TryParse(userInput, out selection))
                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        
                        break;
                    case 2:
                        Console.Clear();
                        
                        break;
                    case 3:
                        Console.Clear();
                        
                        break;
                    case 4:
                        Console.Clear();

                        break;
                    case 5:
                        Console.Clear();

                        break;
                    case 6:
                        // quit program
                        Console.WriteLine("Thank you.");
                        break;
                    default:
                        // invalid user input
                        Console.WriteLine("Invalid input. Please try again");
                        break;
                }
        }
    }
}