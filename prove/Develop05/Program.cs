using Develop05;

// I exceeded requirements by:
// 1. Adding a feature to the breathing activity to keep the breathing shorter if the time
// requested is less than the time it takes to breath in and out, and stop after breathing in if the time has run out
// to try and keep the time as close to the user's specified time as possible, while maintaining five-second breaths.
// 2. Limiting the time for any activity to 60 seconds.
// 3. Using the Fisher-Yates shuffle algorithm to randomly shuffle the list of questions, this along with the above
// time out means the user doesn't see any question more than once, and the activity ends before the list runs out.

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
                        Console.Clear();
                        ReflectionActivity reflectActivity = new ReflectionActivity();
                        reflectActivity.Run();
                        break;
                    case 3:
                        Console.Clear();
                        ListingActivity listActivity = new ListingActivity();
                        listActivity.Run();
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