using System.IO;
public class Journal {
    public string _filename;
    public List<Entry> _entries = new List<Entry>();

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    public void SaveToFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");    
            }
        }
    }
    public void LoadFromFile()
    {
        if(File.Exists(_filename)){
            string[] lines = System.IO.File.ReadAllLines(_filename);
            foreach (string line in lines)
            {
                Entry myEntry = new Entry();
                string[] parts = line.Split(",");
                myEntry._date = parts[0];
                myEntry._prompt = parts[1];
                myEntry._response = parts[2];
                _entries.Add(myEntry);
            }
        }
        else {
            Console.WriteLine($"File name {_filename} does not exist");
        }
    }
}