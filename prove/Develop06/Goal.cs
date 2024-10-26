namespace Develop06;

public abstract class Goal
{
    private string _name;
    private string _description;
    private string _points;

    // constructor
    protected Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    
    // getters and setters
    public string GetName() => _name;
    
    protected string GetDescription() => _description;

    public int GetPoints()
    {
        return int.Parse(_points);
    }
    
    // abstract methods - must be implemented in subclasses
    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();
    
    public abstract int RecordAccomplishment();
    
    public abstract void Reset();

    // virtual methods - provides a generic method that can be overridden by subclasses
    
    public virtual void GetGoalDetails()
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

    public virtual string GetDetailsString()
    {
        string check = " ";
        if (IsComplete())
        {
            check = "x";
        }
        // string format: [x] Name (Description)
        return $"[{check}] {GetName()} ({GetDescription()})";
    }
    
}