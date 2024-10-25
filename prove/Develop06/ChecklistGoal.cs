namespace Develop06;

public class ChecklistGoal(string name, string description, string points, string target, string bonus) : Goal(name, description, points)
{
    private string _target = target;
    private string _bonus = bonus;
    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return GetName()
    }
}