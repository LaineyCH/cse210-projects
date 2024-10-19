namespace Develop05;

public class Activity
{
    protected string _activityName;
    protected string _description;
    private int _duration = 60;
    private List<string> _animationStrings = new List<string>();

    // Getters & Setters
    protected int GetDuration() => _duration;

    private void SetDuration(int duration)
    {
        _duration = duration;
    }

    protected Activity()
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

    protected void GetReady()
    {
        Console.Write("How long, in seconds, would you like for your session? (max 60) ");
        string userTime = Console.ReadLine();

        // try to parse user input to integer
        if (int.TryParse(userTime, out int duration))
        {
            if (duration <= 60)
            {
                SetDuration(duration);
            }
        }
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplayAnimation(3);
    }
    protected void DisplayAnimation(int time)
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

    protected void DisplayCounter(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        DisplayAnimation(3);
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}");
        DisplayAnimation(5);
    }
}
