namespace Develop06;

public class ChecklistGoal(string name, string description, string points, string target, string bonus) : Goal(name, description, points)
{
    private int _amountComplete = 0;
    private int _target = int.Parse(target);
    private int _bonus = int.Parse(bonus);
    public override bool IsComplete()
    {
        // check if target has been achieved, if so, return true
        if (_amountComplete == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public override int RecordAccomplishment()
    {
        // check if target already achieved, if so, reset first number to zero
        if (IsComplete())
        {
            _amountComplete = 0;
        }
        // add 1 to the amount completed
        _amountComplete++;
        
        // check if complete, award bonus if so
        int bonusGained = 0;
        if (IsComplete())
        {
            bonusGained = _bonus;
        }
        
        // add bonus (zero if not awarded) to points
        int points = GetPoints() + bonusGained;
        return (points);
    }

    public override string GetStringRepresentation()
    {
        // string format: goal type, name, description, points
        return $"ChecklistGoal, {GetName()}, {GetDescription()}, {GetPoints()}, {_target}, {_bonus}";
    }
    
    public override string GetDetailsString()
    {
        string check = " ";
        if (IsComplete())
        {
            check = "x";
        }
        // string format: [x] Name (Description) -- Currently completed 0/3
        return $"[{check}] {GetName()} ({GetDescription()}) -- Currently completed {_amountComplete}/{target}";
    }
}