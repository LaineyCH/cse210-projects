namespace Develop06;

public class Goal
{
    protected string _name;
    protected string _description;
    protected string _points;

    protected Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    protected virtual void CreateGoal()
    {
        int selection = 0;

        Console.WriteLine("");
        Console.WriteLine("1. Simple Goal:");
        Console.WriteLine("2. Eternal Goals");
        Console.WriteLine("3. Checklist Goals");
        Console.Write("Which type of goal would you like to create? ");

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
                default:
                    // invalid user input
                    Console.WriteLine("Invalid input. Please try again");
                    break;
            }
    }

    protected virtual void GetGoalDetails()
    {
        string name;
        string description;
        int points;
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with it? ");
        if (int.TryParse(Console.ReadLine(), out points));
    }
}