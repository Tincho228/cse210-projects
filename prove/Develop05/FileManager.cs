using System.Data.SqlTypes;
using System.Dynamic;

public class FileManager
{
    private bool _isSaved;
    private List<Goal> _goals = new List<Goal>();

    public FileManager()
    {
        _isSaved = false;
    }

    public void SaveFile(List<Goal> goals, int points, string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine(points);
                foreach (Goal goal in goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());    
                }
            }
        _isSaved = true;
        Console.WriteLine("File saved.");
    }

    public void LoadFromFile(string fileName)
    {
        if(File.Exists(fileName)){
            string[] lines = System.IO.File.ReadAllLines(fileName);
            int points = int.Parse(lines[0]);
            for (int i = 1; i <= lines.Length -1; i++)
            {
                string[] parts = lines[i].Split(":");
                string goalType = parts[0];
                string details = parts[1];
                string[] splited = details.Split("/");
                if(goalType == "Simple")
                {
                    SimpleGoal sg = new SimpleGoal(splited[0], splited[1], int.Parse(splited[2]), bool.Parse(splited[3]));
                    _goals.Add(sg);
                }
                else if(goalType == "Eternal")
                {
                    EternalGoal eg = new EternalGoal(splited[0], splited[1], int.Parse(splited[2]), bool.Parse(splited[3]), int.Parse(splited[4]));
                    _goals.Add(eg);
                }
                else if(goalType == "Checklist")
                {
                    ChecklistGoal cg = new ChecklistGoal(splited[0], splited[1], int.Parse(splited[2]), bool.Parse(splited[3]), int.Parse(splited[4]), int.Parse(splited[5]), int.Parse(splited[6]));
                    _goals.Add(cg);
                }
            }
        }
        else {
            Console.WriteLine($"File name {fileName} does not exist");
        }
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public bool IsSaved()
    {
        return _isSaved;
    }
}