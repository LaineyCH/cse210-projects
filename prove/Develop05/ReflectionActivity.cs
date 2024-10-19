namespace Develop05;

using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectionActivity() : base()
    {
        _activityName = "Reflection Activity";
        _description = $"Welcome to the {_activityName}.\n \nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
        // add prompts to list
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _prompts.Add("Think of a time when you learned something new and significant.");
        
        // add questions to list
        _questions.Add("> Why was this experience meaningful to you?");
        _questions.Add("> Have you ever done anything like this before?");
        _questions.Add("> How did you get started?");
        _questions.Add("> How did you feel when it was complete?");
        _questions.Add("> What made this time different than other times when you were not as successful?");
        _questions.Add("> What is your favorite thing about this experience?");
        _questions.Add("> What could you learn from this experience that applies to other situations?");
        _questions.Add("> What did you learn about yourself through this experience?");
        _questions.Add("> How can you keep this experience in mind in the future?");
        _questions.Add("> Is there anyone you would like to share this experience with?");
        _questions.Add("> Have you recorded this experience? If not, how could ou do that?");
        _questions.Add("> Is there about this experience you would do differently?");
    }

    public void Run()
    {
        Console.WriteLine(_description);
        Console.WriteLine(" ");
        GetReady();
        
        Console.WriteLine("\n");
        String prompt = GetPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"——— {prompt} ———");
        Console.WriteLine(" ");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("You may begin in ");
        DisplayCounter(5);

        Console.Clear();
        DisplayQuestions();
        
        Console.WriteLine("\n");
        DisplayEndMessage();
    }

    private string GetPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        return prompt;
    }
    
    private void DisplayQuestions()
    {
        // Randomly shuffle the questions list using the Fisher-Yates shuffle algorithm
        for (int i = _questions.Count - 1; i > 0; i--)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, i + 1);
            string temp = _questions[i];
            _questions[i] = _questions[randomIndex];
            _questions[randomIndex] = temp;
        }
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        
        // Loop through each question in the list
        foreach (string question in _questions)
        {
            Console.Write($"{question}  ");
            DisplayAnimation(5);
            Console.WriteLine(" ");

            // Check if the time limit has been reached
            if (DateTime.Now >= endTime)
                break;
        }
    }
}