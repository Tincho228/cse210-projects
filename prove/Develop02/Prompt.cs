using System.Globalization;

public class Prompt {
    public List<string> _prompts = new List<string>();

    public Prompt() {
        _prompts.Add("How are you feeling today? ");
        _prompts.Add("What was the best thing you achieved today? ");
        _prompts.Add("Something You do not want to forget? ");
        _prompts.Add("What did you learn today? ");
        _prompts.Add("What are you grateful for? ");
        _prompts.Add("Any reflexion or personal revelation? ");
        _prompts.Add("What things you want to improve? ");
        _prompts.Add("Did something special happen today ");
        _prompts.Add("Any personal new goals today. ");
    }
    public string PromptGenerator()
    {
        Random random = new Random();
        int rand_number = random.Next(0,_prompts.Count());
        return _prompts[rand_number];
    }
}