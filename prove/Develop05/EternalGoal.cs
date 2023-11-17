public class EternalGoal:Goal
{
    private int _counter;

    public EternalGoal():base()
    {
    }
    
    public EternalGoal(string name, string description, int points, bool isComplete, int counter):base(name, description, points, isComplete)
    {
        _counter = counter;
    }

    public override void SetGoalValues()
    {
        base.SetGoalValues();
        _counter = 0;
    }

    public override string DiplayGoal()
    {
        return $"[ ] {_goalName} ({_goalDescription})";
    }

    public override int PointsCounter()
    {
        return _counter * _goalPoints;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        _counter++;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal:{_goalName}/{_goalDescription}/{_goalPoints}/{_isComplete}/{_counter}";
    }
    
}