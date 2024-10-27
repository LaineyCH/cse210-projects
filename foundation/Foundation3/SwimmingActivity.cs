namespace Foundation3;

public class SwimmingActivity(string date, double lengthOfActivity, double laps) : Activity(date, lengthOfActivity)
{
    private double _laps = laps; // each lap = 50m

    public override double CalcDistance()
    {
        // returns the distance in km
        return Math.Round((_laps * 50 / 1000), 2);
    }

    public override double CalcSpeed()
    {
        // returns the speed in km/h
        return Math.Round((CalcDistance() / (GetLengthOfActivity() / 60)), 2);
    }

    // returns the pace in min per km
    public override double CalcPace()
    {
        return Math.Round((GetLengthOfActivity() / CalcDistance()), 2);
    }
    
    public override string GetActivityType()
    {
        return "Swimming";
    }
}