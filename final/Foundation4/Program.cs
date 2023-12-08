using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> activities = new List<Activity>();
        
        RunningActivity ra = new RunningActivity("Nov 5 2024",30,4.8);
        activities.Add(ra);
        CyclingActivity ca = new CyclingActivity("Nov 5 2024",30,5);
        activities.Add(ca);
        SwimmingActivity sa = new SwimmingActivity("Nov 10 2024",30,5);
        activities.Add(sa);
        
        foreach (Activity a in activities)
        {
            a.GetSummary();
        }
    }
}