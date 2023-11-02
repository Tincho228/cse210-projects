public class BreathingActivity:Activity 
{
    public BreathingActivity(string name, string description):base(name, description){

    }

    public void RunBreathingActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityTime);
        while(DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breath in...");
            CountdownAnimation(3);
            Console.WriteLine();
            Console.Write("Breath out...");
            CountdownAnimation(5);
            Console.WriteLine();
        }
    }
    
}