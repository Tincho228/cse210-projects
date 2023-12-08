public class SwimmingActivity:Activity
{
    private double _lapsNumber;

    public SwimmingActivity(string date, int length, double lapsNumber):base(date,length)
    {
         _type = "Swimming"; 
         _lapsNumber = lapsNumber;
    }

    public override double GetDistance()
    {        
        _distance = _lapsNumber * 50 / 1000; 
        return _distance;
    }

}