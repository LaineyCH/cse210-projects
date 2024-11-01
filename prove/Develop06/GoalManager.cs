namespace Develop06;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    // constructor
    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    // methods
    public void Start()
    {
        // display main menu options
        int selection = 0;
        while (selection != 8)
        {
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
                        // let the user create a new goal
                        CreateGoal();
                        break;
                    case 2:
                        // list all the goals in the list of goals
                        ListGoals();
                        break;
                    case 3:
                        // save the score and the list of goals to a user specified file (overrides any existing data)
                        SaveGoals();
                        break;
                    case 4:
                        // load score and list of goals from user specifoed file (overrides the existing goal list)
                        LoadGoals();
                        break;
                    case 5:
                        // check is goal list is empty
                        if (_goals.Count == 0)
                        {
                            Console.WriteLine("There are no goals in your list.");
                            break;
                        }
                        // let the user mark a goal as accomplished and award the relevant score
                        string question5 = "Which goal did you accomplish? ";
                        try
                        {
                            Goal selectedGoal = GoalSelect(question5);
                            RecordAccomplishment(selectedGoal);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please try again");
                        }
                        break;
                    case 6:
                        // check is goal list is empty
                        if (_goals.Count == 0)
                        {
                            Console.WriteLine("There are no goals in your list.");
                            break;
                        }
                        // reset an existing goal to incomplete (eternal goals will reset to zero tasks completed)
                        string question6 = "Which goal would you like to reset to 'incomplete'? ";
                        try
                        {
                            Goal resetGoal = GoalSelect(question6);
                            ResetGoal(resetGoal);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please try again");
                        }
                        break;
                    case 7:
                        // check is goal list is empty
                        if (_goals.Count == 0)
                        {
                            Console.WriteLine("There are no goals in your list.");
                            break;
                        }
                        // let the user remove/delete a chosen goal from the list of goals
                        string question7 = "Which goal would you like to delete? ";
                        try
                        {
                            Goal deleteGoal = GoalSelect(question7);
                            DeleteGoals(deleteGoal);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please try again");
                        }
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
            DisplayScore();
        }
    }
    
    // display the score
    private void DisplayScore()
    {
        Console.WriteLine("");
        Console.WriteLine($"You have {_score} points.");
    }

    // create a new user defined goal object and add it to the list of goals
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
            if (selection is not (1 or 2 or 3))
            {
                // invalid user input
                Console.WriteLine("Invalid input. Please try again");
                return;
            }
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
                default:
                    // invalid user input
                    Console.WriteLine("Invalid input. Please try again");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again");
        }
    }

    // display the list of goals in a numbered list showing completion status
    private void ListGoals()
    {
        Console.WriteLine(" ");
        Console.WriteLine("GOALS:");
        int i = 1;
        foreach (Goal g in _goals)
        {
            string goalString = g.GetDetailsString();
            Console.WriteLine($"{i}. {goalString}");
            i++;
        }
    }

    // save score and list of goals to a user specified txt file
    private void SaveGoals()
    {
        Console.Write("Please enter the file name: ");
        string filename = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.GetStringRepresentation());
            }
        }
    }
    
    // load score and list of goals from user specified txt file
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
                    // read the first line and parse it as the score
                    if (int.TryParse(sr.ReadLine(), out int parsedScore))
                    {
                        _score = parsedScore;
                    }
                    
                    // clear the goals list
                    _goals.Clear();
                    string line;
                    // read the rest of the file one line at a time, and parse
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

    // update completion status for goal object and add points awarded to score
    private void RecordAccomplishment(Goal goal)
    {
        int points = goal.RecordAccomplishment();
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        _score += points;
        Console.WriteLine($"You now have {_score} points.");
    }

    // returns a user specified goal object from the list of goals
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

        Console.Write(question);
        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int selection))
        {
            if (selection > _goals.Count)
            {
                // invalid user input
                throw new FormatException("Invalid input. Please try again.");
            }
            return _goals[selection - 1];
        }
        else
        {
            throw new FormatException("Invalid input. Please try again.");
        }
    }

    // resets completion status of goal object to incomplete
    private void ResetGoal(Goal goal)
    {
        goal.Reset();
    }

    // removes/deletes a goal object from he list of goals
    private void DeleteGoals(Goal goal)
    {
        _goals.Remove(goal);
    }
    
}