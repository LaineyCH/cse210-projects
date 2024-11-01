using System;
using Develop06;

// I have exceeded requirements in the following ways:
// 1. Eternal Goals, once they have been completed, if the user records another accomplishment, it resets and allows
//    the user to start again (points already awarded are retained).
// 2. The user can reset any goal so that it becomes incomplete (eternal goals reset to 0 tasks completed).
// 3. The user can delete any goal.
// 4. Add error handling for user input and possible empty goal list.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");
        Console.WriteLine("---------- Welcome to the ETERNAL QUEST PROGRAM ----------");
        // create a new Goal Manager
        GoalManager gm = new GoalManager();
        // start the program
        gm.Start();
    }
}