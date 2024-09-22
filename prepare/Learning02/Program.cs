using System;
using Learning02;

class Program
{
    static void Main(string[] args)
    {
        // create instances of Job objects
        Job job1 = new Job();
        Job job2 = new Job();
        // set member variables
        job1._jobTitle = "Software Developer";
        job1._company = "Apple";
        job1._startYear = 2015;
        job1._endYear = 2018;
        job2._jobTitle = "Dev Ops";
        job2._company = "Microsoft";
        job2._startYear = 2018;
        job2._endYear = 2021;
        
        // create an instance of Resume
        Resume resume1 = new Resume();
        // set member variables
        resume1._name = "John Smith";
        // add jobs
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        
        // display the resume
        resume1.Display();
    }
}