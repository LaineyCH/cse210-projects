namespace Develop05;

public class Activity
{
    protected string _activityName = "Mindfulness Activity";
    protected string _description;
    private int _duration = 0;
    private List<string> _animationStrings = new List<string>();

    // Getters & Setters
    protected int GetDuration() => _duration;

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public Activity()
    {
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("—");
        _animationStrings.Add("\\");
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("—");
        _animationStrings.Add("\\");
    }

    public void GetReady()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string userTime = Console.ReadLine();

        // try to parse user input to integer
        if (int.TryParse(userTime, out int duration))
        {
            SetDuration(duration);
        }
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplayAnimation(5);
    }
    public void DisplayAnimation(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = _animationStrings[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");
            i++;
            // loop back to beginning of animation string list wen the end is reached
            if (i >= _animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void DisplayCounter()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b \b");
        }
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Well done!!\nYou have completed another {_duration} seconds of the {_activityName}");
        DisplayAnimation(5);
    }
}
