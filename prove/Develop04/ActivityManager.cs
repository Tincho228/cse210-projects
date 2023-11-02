public class ActivityManager
{
    private List<Activity> _activities = new List<Activity>();
    private string _names;
    private string _filename = "activities.txt";

    public ActivityManager()
    {
        if(File.Exists(_filename)){
            string[] lines = System.IO.File.ReadAllLines(_filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("/");
                Activity act = new Activity(parts[0],parts[1]);
                _activities.Add(act); 
            }
        }
        else {
            Console.WriteLine($"File name {_filename} does not exist");
        }
    }

    public Activity GetActivity(int index)
    {
        return _activities[index];
    }

    public string GetActivityNames()
    {
        foreach(Activity act in _activities)
        {
             _names += act.GetName() + ",";
        }
        return _names;
    }

}