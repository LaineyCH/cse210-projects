public class Swimming : Activity
{
    // VARIABLES
    private double _laps; // in X laps

    // CONSTRUCTORS
    public Swimming(string date, double duration, double laps) : base(date, duration)
    {
        _laps = laps;
        // Console.WriteLine($"Swimming Laps: {_laps}");// TESTING
    }

    // METHODS
    public override string GetSummary()
    {
        double duration = Duration();
        string date = Date();

        double distance = _laps * 50 / 1000 * 0.62;
        double speed = distance / duration * 60;
        double pace = duration / distance;

        // Console.WriteLine($"Swimming Duration: {duration}");//TESTING
        // Console.WriteLine($"Swimming Distance: {distance}");//TESTING
        // Console.WriteLine($"Swimming Speed: {speed}");//TESTING
        // Console.WriteLine($"Swimming Pace: {pace}");//TESTING
        // // Console.WriteLine($"Swimming Date: {date}");//TESTING

        string activitySummary = $"{date} Swimming ({duration} min.) - Distance: {distance:N2} miles, Speed: {speed:N2} mph, Pace: {pace:N2} minutes per mile";
        return activitySummary;
    }
}