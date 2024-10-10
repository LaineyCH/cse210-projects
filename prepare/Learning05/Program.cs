using System;
using Learning05;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Marge Moag", "All About Cats");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("David George", "Engineering", "B5", "1-182");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        
        WritingAssignment writingAssignment = new WritingAssignment("Barbara Currie", "History of Art", "The Baroque Pariod");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}