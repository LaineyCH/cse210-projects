namespace Foundation3;

public class CyclingActivity(string date, double lengthOfActivity, double speed) : Activity(date, lengthOfActivity)
{
    private double _speed = speed; // in km/h

    public override double CalcDistance()
    {
        // returns distance in km
        return Math.Round(_speed * (GetLengthOfActivity() / 60), 1);
    }

    public override double CalcSpeed()
    {
        // returns the speed in km/h
        return Math.Round(_speed, 1);
    }

    // returns the pace in min per km
    public override double CalcPace()
    {
        return Math.Round((60 / _speed), 1);
    }
    
    public override string GetActivityType()
    {
        return "Cycling";
    }
}