public class ListingActivity:Activity 
{
    private List<string> _prompts = new List<string>();
    public ListingActivity(string name, string description):base(name, description){
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randNumber = random.Next(0,_prompts.Count());
        return _prompts[randNumber];
    }

    public void RunListingActivity()
    {
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine("\n--- "+ GetRandomPrompt() + " ---");
        Console.Write("You may begin in:");
        CountdownAnimation(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityTime);
        List<string> responses = new List<string>();
        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userResponse = Console.ReadLine();
            responses.Add(userResponse);
        }
        Console.WriteLine($"You listed {responses.Count()} items");
    }
}