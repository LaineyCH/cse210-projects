namespace Develop06;

public class EternalGoal(string name, string description, string points): Goal(name, description, points)
{
    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordAccomplishment()
    {
        return GetPoints();
    }

    public override string GetStringRepresentation()
    {
        // string format: goal type | name, description, points
        return $"EternalGoal, {GetName()}, {GetDescription()}, {GetPoints()}";
    }
    
    public override void Reset()
    {
    }
}