using System.ComponentModel.DataAnnotations;

public class Activity
{
    private string _date;
    protected double _length;

    protected double _distance; //km
    protected string _type;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        return _distance; // km
    }

    public virtual double GetSpeed()
    {
        double speed = _distance/_length; // km per min
        return speed * 60; // km per hour
    }

    public double GetPace()
    {
        return _length/_distance;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_type} ({_length} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km.");
    }
}