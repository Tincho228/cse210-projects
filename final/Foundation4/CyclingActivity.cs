public class CyclingActivity:Activity
{
    private int _speed;   

    public CyclingActivity(string date, int length, int speed):base(date,length)
    {
         _type = "Cycling"; 
         _speed = speed;
    }

    public override double GetDistance()
    {
        _distance = _speed * _length / 60; 
        return base.GetDistance();
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}