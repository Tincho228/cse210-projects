public class Menu 
{   
    private string _menuString;
    private string _typeString; 

    public Menu(List<string> names)
    {
        // Create the goal types menu
        _typeString = "The types of goals are:\n";
        int i = 0;
        foreach(string name in names)
        { 
            _typeString += $"   {i + 1}. Start {name} Goal \n";
            i++;
        }
        _typeString += "Which type of Goal would you like to create? ";
        // Create the menu options
        _menuString = "Menu options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\nSelect a choice from the menu: ";
    }

    public void DisplayMenuOptions()
    {
        Console.Write(_menuString);
    }

    public void DiplayGoalOptions()
    {
        Console.Write(_typeString);
    }

    public void DisplayRecordEventOptions(List<string> names)
    {
        int i = 1;
        foreach(string name in names)
        {
            Console.WriteLine($"   {name}");
            i++;
        }
        Console.Write("What goal would you like to record? ");
    }
}