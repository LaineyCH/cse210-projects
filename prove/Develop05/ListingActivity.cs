namespace Develop05;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private int _itemCount = 0;
    
    public ListingActivity() : base()
    {
        _activityName = "Listing Activity";
        _description = $"Welcome to the {_activityName}.\n \nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
        // add prompts to list
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        Console.WriteLine(_description);
        Console.WriteLine(" ");
        GetReady();
        
        Console.WriteLine("\n");
        String prompt = GetPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"——— {prompt} ———");
        Console.WriteLine(" ");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("You may begin in ");
        DisplayCounter(5);

        Console.Clear();

        LetUserList();
        
        Console.WriteLine("\n");
        DisplayEndMessage();
    }
    
    private string GetPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        return prompt;
    }

    private void LetUserList()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _itemCount++;
        }
        Console.WriteLine($"You listed {_itemCount} items!");
    }
}