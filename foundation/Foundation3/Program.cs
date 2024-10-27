using System;
using Foundation3;

class Program
{
    static void Main(string[] args)
    {
        // create a new list for activities
        List<Activity> activities = new List<Activity>();

        // create instances of the various activity subclasses and add them to the list
        RunningActivity r1 = new RunningActivity("03 Nov 2022", 30, 3.0);
        activities.Add(r1);
        CyclingActivity c1 = new CyclingActivity("08 Nov 2022", 125, 22.3);
        activities.Add(c1);
        RunningActivity r2 = new RunningActivity("22 Nov 2022", 30, 4.8);
        activities.Add(r2);
        SwimmingActivity s1 = new SwimmingActivity("01 Dec 2022", 22, 21);
        activities.Add(s1);
        CyclingActivity c2 = new CyclingActivity("09 Dec 2022", 78, 25.8);
        activities.Add(c2);
        SwimmingActivity s2 = new SwimmingActivity("15 Dec 2022", 23, 24);
        activities.Add(s2);

        // go through the list of activities and print the summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.Summary());
        }
        
    }
}