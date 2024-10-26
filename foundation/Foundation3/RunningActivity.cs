namespace Foundation3;

public class RunningActivity(string date, double lengthOfActivity, double distance) : Activity(date, lengthOfActivity)
{
    private double _distance = distance;  // in km
    
    public override double CalcDistance()
    {
        // returns the distance in km
        return Math.Round(_distance, 1);
    }

    public override double CalcSpeed()
    {
        // returns the speed in kph
        return Math.Round(_distance / (GetLengthOfActivity() / 60), 1);
    }

    public override double CalcPace()
    {
        // returns the pace in min per km
        return Math.Round(GetLengthOfActivity() / _distance, 1);
    }

    public override string GetActivityType()
    {
        return "Running";
    }
    
}