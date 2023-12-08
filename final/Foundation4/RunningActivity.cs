public class RunningActivity:Activity
{
    
    public RunningActivity(string date, int length, double distance):base(date,length)
    {
        _type = "Running";   
        _distance = distance;    
    }
}