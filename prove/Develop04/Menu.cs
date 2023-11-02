using System.Diagnostics;
using System.Linq.Expressions;
using System.Net;

public class Menu 
{   
    private string _menuString; 

    public Menu(string activityNames)
    {
        string[] activities = activityNames.Split(",");
        _menuString = "Menu options:\n";
        for(int i = 0 ; i < activities.Length - 1; i ++)
        {           
            _menuString += $"   {i+1}. Start {activities[i]} activity \n";
        }
        _menuString += $"   {activities.Length}. Quit \n";
        _menuString += "Select a choice from the menu: ";
    }

    public void DisplayMenuOptions()
    {
        Console.Write(_menuString);
    }

}