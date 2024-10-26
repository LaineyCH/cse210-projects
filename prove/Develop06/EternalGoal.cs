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
        return name + ", " + description + ", " + points;
    }
}