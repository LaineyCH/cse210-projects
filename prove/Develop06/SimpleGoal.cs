namespace Develop06;

public class SimpleGoal(string name, string description, string points, bool isComplete = false): Goal(name, description, points)
{
    private bool _isComplete = isComplete;
    
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordAccomplishment()
    {
        _isComplete = true;
        return GetPoints();
    }

    public override string GetStringRepresentation()
    {
        // string format: goal type, name, description, points
        return $"SimpleGoal, {GetName()}, {GetDescription()}, {GetPoints()}, {IsComplete()}";
    }
}