namespace Foundation3;

public abstract class Activity(string date, double lengthOfActivity)
{
    private string _date = date; // format: "03 Nov 2022"
    private double _lengthOfActivity = lengthOfActivity; // in minutes
    
    // getters and setters
    public string GetDate() => _date;
    public double GetLengthOfActivity() => _lengthOfActivity;
    
    public string Summary()
    {
        // format: 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"  \u25e6 {_date} {GetActivityType()} ({GetLengthOfActivity().ToString("F2")} min) - Distance: {CalcDistance().ToString("F2")} km, Speed: {CalcSpeed().ToString("F2")} kph, Pace: {CalcPace().ToString("F2")} min per km";
    }
    
    // abstract methods
    public abstract double CalcDistance();
    public abstract double CalcSpeed();
    public abstract double CalcPace();
    public abstract string GetActivityType();
}