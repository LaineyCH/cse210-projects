using System;

class Program
{
    static void Main(string[] args)
    {
        bool pass = true;
        string letter = "";
        string sign = "";
        Console.Write("What is your grade percentage? (eg: 64) ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
            pass = false;
        }
        else
        {
            letter = "F";
            pass = false;
        }
        
        int rightMostDigit = grade % 10;
        if (grade >= 60)
        {
            if (rightMostDigit >= 7 && grade <= 90)
            {
                sign = "+";
            }
            else if (rightMostDigit < 3)
            {
                sign = "-";
            }
        }
        
        Console.Write($"Your letter grade is {letter}{sign}, ");
        if (pass)
        {
            Console.WriteLine($"you have passed the course. Congratulations!");
        }
        else
        {
            Console.WriteLine($"you have not passed the course this time, but please try again.");
        }
    }
}