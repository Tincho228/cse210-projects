public class ChecklistGoal:Goal
{
    private int _bonus;
    private int _steps;
    private int _counter;

    public ChecklistGoal():base()
    {
        
    }

    public ChecklistGoal(string name, string description, int points, bool isComplete, int counter, int bonus, int steps):base(name, description, points, isComplete)
    {
        _counter = counter;
        _bonus = bonus;
        _steps = steps;
    }

    public override void SetGoalValues()
    {
        base.SetGoalValues();
        Console.Write("How many times does this goal need to be accomplihed for a bonus? ");
        _steps = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
        _counter = 0;
    }

    public override string DiplayGoal()
    {
        if(_isComplete)
        {
            return $"[X] {_goalName} ({_goalDescription}) -- Currently completed: {_counter}/{_steps}";
        }
        else{
            return $"[ ] {_goalName} ({_goalDescription}) -- Currently completed: {_counter}/{_steps}";
        }
    }

    public override int PointsCounter()
    {
        int stepPoints = _goalPoints * _counter;
        if(_isComplete)
        {
            return stepPoints + _bonus;
        }
        else
        {
            return stepPoints;
        }
    }

    public override void RecordEvent()
    {
        if(_counter < _steps)
        {
            _counter ++;
        }
        if (_counter == _steps)
        {
            _isComplete = true;
            
            Console.Write($"You have earned a bonus of {_bonus} points!!!");
            SpinningAnimation(3);
            
        }
        base.RecordEvent();
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist:{_goalName}/{_goalDescription}/{_goalPoints}/{_isComplete}/{_counter}/{_bonus}/{_steps}";
    }
}