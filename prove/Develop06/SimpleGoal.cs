namespace Develop06;

public class SimpleGoal(string name, string description, string points): Goal(name, description, points)
{
    private bool _isComplete = false;
    public override bool IsComplete()
    {
        return _isComplete;
    }
}