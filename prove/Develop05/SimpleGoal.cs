public class SimpleGoal:Goal
{
    public SimpleGoal():base()
    {
    }

    public SimpleGoal(string name, string description, int points, bool isComplete):base(name, description, points, isComplete)
    {
    
    }

    public override void RecordEvent()
    {
        _isComplete = true; 
        base.RecordEvent();
    }

    public override string GetStringRepresentation()
    {
        return $"Simple:{_goalName}/{_goalDescription}/{_goalPoints}/{_isComplete}";
    }
}