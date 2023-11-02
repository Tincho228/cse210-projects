public class ReflectingActivity:Activity {
    private List<string> _messages = new List<string>();
    private List<string> _prompts = new List<string>();
    public ReflectingActivity(string name, string description):base(name, description){

        //Populating Messages
        _messages.Add("Think of a time when you stood up for someone else.");
        _messages.Add("Think of a time when you did something really difficult.");
        _messages.Add("Think of a time when you helped someone in need.");
        _messages.Add("Think of a time when you did something truly selfless.");
        //Populating Prompts
        _prompts.Add("Why was this experience meaningful to you?");
        _prompts.Add("Have you ever done anything like this before?");
        _prompts.Add("How did you get started?");
        _prompts.Add("How did you feel when it was complete?");
        _prompts.Add("What made this time different than other times when you were not as successful?");
        _prompts.Add("What is your favorite thing about this experience?");
        _prompts.Add("What could you learn from this experience that applies to other situations?");
        _prompts.Add("What did you learn about yourself through this experience?");
        _prompts.Add("How can you keep this experience in mind in the future?");
    }

    public void RunReflectingActivity()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine("\n--- "+ GetRandomMessage() + " ---");
        Console.Write("\nWhen you have something in mind, press enter to continue: ");
        string userResponse = Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:");
        CountdownAnimation(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityTime);
            foreach(string prompt in _prompts)
            {
                if(DateTime.Now < endTime){
                    Console.Write("> " + prompt + " ");
                    SpinningAnimation(4);
                    Console.WriteLine();
                }
            }
    }

    public string GetRandomMessage()
    {
        Random random = new Random();
        int randNumber = random.Next(0,_messages.Count());
        return _messages[randNumber];
    }
}