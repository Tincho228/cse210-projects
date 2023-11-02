public class Activity 
{
    private string _activityName;
    protected int _activityTime;
    private string _activityDescription;

    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }

    public string GetName(){
        return _activityName;
    }

    public string GetDescription()
    {
        return _activityDescription;
    }

    public void DisplayStartMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.\n\n {_activityDescription}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        int userInput = int.Parse(Console.ReadLine());
        SetActivityTime(userInput);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        SpinningAnimation(4);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        SpinningAnimation(3);
        Console.WriteLine($"You have completed another {_activityTime} seconds of the {_activityName} Activity");
        SpinningAnimation(4);
        Console.Clear();
    }

    public void SetActivityTime(int time)
    {
        _activityTime = time;
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

    public void CountdownAnimation(int time){
        for(int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}