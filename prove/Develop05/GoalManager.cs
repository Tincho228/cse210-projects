using System.Runtime.InteropServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private List<string> _goalNames = new List<string>();
    private int _goalpoints;

    public GoalManager(){
        _goalNames.Add("Simple");
        _goalNames.Add("Eternal");
        _goalNames.Add("Checklist");
    }

    public List<string> GetNamesList()
    {
        return _goalNames;
    } 

    public void AddNewGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("The goals are: ");
        int i = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.DiplayGoal()}");
            i++;
        }
    }

    public int CountPoints()
    {
        _goalpoints = 0;

        foreach(Goal goal in _goals)
        {
            _goalpoints += goal.PointsCounter();
        }
        return _goalpoints;
    }

    public void RecordEvent(int index)
    {
        _goals[index].RecordEvent();
    }

    public List<string> GetGoalNames()
    {
        List<string> names = new List<string>();
        int i = 0;
        foreach(Goal goal in _goals)
        {
            if(!goal.IsComplete())
            {
                names.Add($"{i+1}. "+goal.GetName());
            }
            i++;
        }
        return names;
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }
    
    public void LoadGoals(List<Goal> goals)
    {
        _goals = goals;
    }
} 