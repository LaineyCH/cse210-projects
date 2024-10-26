namespace Develop06;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    private void DisplayScore()
    {
        foreach (Goal g in _goals)
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
        while (selection != 8)
        {
            DisplayScore();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Accomplished Goal");
            Console.WriteLine("6. Reset Goal Completion");
            Console.WriteLine("7. Delete Goal");
            Console.WriteLine("8. Quit");
            Console.Write("Select a choice from the menu: ");
            
            // Get user selection
            string userInput = Console.ReadLine();
            
            // try to parse user input to integer
            if (int.TryParse(userInput, out selection))
                switch (selection)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        ListGoals();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        string question5 = "Which goal did you accomplish? ";
                        Goal selectedGoal = GoalSelect(question5);
                        RecordAccomplishment(selectedGoal);
                        break;
                    case 6:
                        string question6 = "Which goal would you like to reset to 'incomplete'? ";
                        Goal resetGoal = GoalSelect(question6);
                        ResetGoal(resetGoal);
                        break;
                    case 7:
                        string question7 = "Which goal would you like to delete? ";
                        Goal deleteGoal = GoalSelect(question7);
                        DeleteGoals(deleteGoal);
                        break;
                    case 8:
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

        if (int.TryParse(userInput, out int selection))
        {
            Console.WriteLine("");
            Console.WriteLine("What is the name of your goal?  ");
            string goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of it?  ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?  ");
            string points = Console.ReadLine();
            switch (selection)
            {
                case 1:
                    SimpleGoal sg = new SimpleGoal(goalName, description, points);
                    _goals.Add(sg);
                    break;
                case 2:
                    EternalGoal eg = new EternalGoal(goalName, description, points);
                    _goals.Add(eg);
                    break;
                case 3:
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    string target = Console.ReadLine();
                    Console.WriteLine("What is the bonus for accomplishing it that many times?  ");
                    string bonus = Console.ReadLine();
                    ChecklistGoal cg = new ChecklistGoal(goalName, description, points, target, bonus);
                    _goals.Add(cg);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again");
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("GOALS:");
        int i = 1;
        foreach (Goal g in _goals)
        {
            string goalString = g.GetDetailsString();
            Console.WriteLine($"{i}. {goalString}");
            i++;
        }
    }

    private void SaveGoals()
    {
        Console.Write("Please enter the file name: ");
        string filename = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.GetStringRepresentation());
            }
        }
    }
    
    private void LoadGoals()
    { 
        bool fileOpened = false;
        while (!fileOpened)
        {
            Console.Write("Please enter the file name: ");
            string readFileName = Console.ReadLine();
            try
            {
                using (StreamReader sr = new StreamReader(readFileName))
                {
                    // clear the goals list
                    _goals.Clear();
                    string line;
                    // ead from file and parse one line at a time
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(",");
                        string goalType = parts[0].Trim();
                        string name = parts[1].Trim();
                        string description = parts[2].Trim();
                        string points = parts[3].Trim();
                        switch (goalType)
                        {
                            case "SimpleGoal":
                                bool isComplete = bool.Parse(parts[4].Trim());
                                SimpleGoal sg = new SimpleGoal(name, description, points, isComplete);
                                _goals.Add(sg);
                                break;
                            case "EternalGoal":
                                EternalGoal eg = new EternalGoal(name, description, points);
                                _goals.Add(eg);
                                break;
                            case "ChecklistGoal":
                                string target = parts[4].Trim();
                                string bonus = parts[5].Trim();
                                string amountComplete = parts[6].Trim();
                                ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus, amountComplete);
                                _goals.Add(cg);
                                break;
                        }

                    }
                    fileOpened = true;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found, please try again.");
            }
        }
    }

    private void RecordAccomplishment(Goal goal)
    {
        int points = goal.RecordAccomplishment();
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        _score += points;
        Console.WriteLine($"You now have {_score} points.");
    }

    private Goal GoalSelect(string question = "Which goal?")
    {
        Console.WriteLine("");
        int i = 1;
        foreach (Goal g in _goals)
        {
            string name = g.GetName();
            Console.WriteLine($"{i}. {name}");
            i++;
        }
        Console.Write("Which goal did you accomplish? ");
        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int selection))
            return _goals[selection - 1];
        else
        {
            throw new FormatException("Invalid input. Please try again.");
        }
    }

    private void ResetGoal(Goal goal)
    {
        goal.Reset();
    }

    private void DeleteGoals(Goal goal)
    {
        _goals.Remove(goal);
    }
    
}