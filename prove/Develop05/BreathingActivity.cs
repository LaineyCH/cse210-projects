namespace Develop05;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _activityName = "Breathing Activity";
        _description = $"Welcome to the {_activityName}.\n \nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Console.WriteLine(_description);
        Console.WriteLine(" ");
        SetDuration();
        Console.WriteLine(" ");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n");
            Console.Write("Breathe in... ");
            DisplayCounter();
            Console.WriteLine("");
            Console.Write("And breathe out... ");
            DisplayCounter();
        }
        DisplayEndMessage();
    }
}