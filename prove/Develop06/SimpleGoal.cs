namespace Develop06;

public class SimpleGoal(string name, string description, string points): Goal(name, description, points)
{
    private bool _isComplete = false;
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
        throw new NotImplementedException();
    }
}