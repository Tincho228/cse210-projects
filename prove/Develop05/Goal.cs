using System.ComponentModel;

public class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    protected bool _isComplete;

    public Goal()
    {
        
    }
    
    public Goal(string name, string description, int points, bool isComplete)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
        _isComplete = isComplete;
    }

    public virtual void SetGoalValues()
    {
        Console.Write("Name of the goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
        _isComplete = false;
    }

    public string GetName()
    {
        return _goalName;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public virtual string DiplayGoal()
    {
        if(_isComplete)
        {
            return $"[X] {_goalName} ({_goalDescription})";
        }
        else
        {
            return $"[ ] {_goalName} ({_goalDescription})";
        } 
    }

    public virtual int PointsCounter()
    {
        if (_isComplete)
        {
            return _goalPoints;
        }
        else
        {
            return 0;
        }   
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"Congratulations you have earned {_goalPoints}!!!");
    }
    
    public virtual string GetStringRepresentation()
    {
        return "";
    }

    public void SpinningAnimation(int time){
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("—");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("—");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        int i = 0;
        while(DateTime.Now < endTime)
        {
            string part = animationStrings[i];
            Console.Write(part);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if(i >= animationStrings.Count())
            {
                i = 0;
            }
        }
    }
}