using System;
using Develop05;

class Program
{
    static void Main(string[] args)
    {
        int selection = 0;
        while (selection != 4)
        {
            Console.Clear();
            Console.WriteLine("MINDFULNESS PROGRAM");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice: ");
            
            // Get user selection
            string userInput = Console.ReadLine();
            
            // try to parse user input to integer
            if (int.TryParse(userInput, out selection))
                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        BreathingActivity breathActivity = new BreathingActivity();
                        breathActivity.Run();
                        break;
                    case 2:
                        
                        break;
                    case 3:
                       
                        break;
                    case 4:
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