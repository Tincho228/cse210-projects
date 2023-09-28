using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2005;
        job1._endYear = 2007;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Data entry";
        job2._startYear = 2007;
        job2._endYear = 2023;

        Resume resume = new Resume();
        resume._name = "Martin Quintero";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
        
    }
}