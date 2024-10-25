namespace Develop06;

public class GoalManager
{
    private List<Goal> goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        List<Goal> goals = new List<Goal>();
    }

    private void DisplayScore()
    {
        foreach (Goal g in goals)
        {
            if (g.IsComplete())
            {
                g.GetPoints();
            }
            
        }
        Console.WriteLine("");
        Console.WriteLine($"You have {_score} points.");
    }
    
    public void Start()
    {
        int selection = 0;
        while (selection != 6)
        {
            DisplayScore();
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
                        CreateGoal();
                        break;
                    case 2:
                        Console.Clear();
                        ListGoals();
                        break;
                    case 3:
                        Console.Clear();
                        SaveGoals();
                        break;
                    case 4:
                        Console.Clear();
                        LoadGoals();
                        break;
                    case 5:
                        Console.Clear();
                        ListGoalNames();
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

    private void CreateGoal()
    {
        Console.WriteLine("");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        // Get user selection
        string userInput = Console.ReadLine();
        
        Console.WriteLine("");
        Console.WriteLine("What is the name of your goal?  ");
        string goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it?  ");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?  ");
        string points = Console.ReadLine();
        
        if (int.TryParse(userInput, out int selection))
            switch (selection)
            {
                case 1:
                    SimpleGoal sg = new SimpleGoal(goalName, description, points);
                    break;
                case 2:
                    EternalGoal eg = new EternalGoal(goalName, description, points);
                    break;
                case 3:
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    string target = Console.ReadLine();
                    Console.WriteLine("What is the bonus for accomplishing it that many times?  ");
                    string bonus = Console.ReadLine();
                    ChecklistGoal cg = new ChecklistGoal(goalName, description, points, target, bonus);
                    break;
            }
    }

    private void ListGoals()
    {
        foreach (Goal g in goals)
        {
            g.GetStringRepresentation();
        }
    }

    private void SaveGoals()
    {
        foreach (Goal g in goals)
        {
            // save to file
        }
    }
    
    private void LoadGoals()
    { 
        // load from file
    }

    private void RecordEvent(Goal goal)
    {
        
    }

    private List<string> ListGoalNames()
    {
        List<string> goalNames = new List<string>();
        foreach (Goal g in goals)
        {
            goalNames.Add(g.GetName());
        }
        
        return goalNames;
    }
    
}