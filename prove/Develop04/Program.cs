using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "1";
        ActivityManager am = new ActivityManager();
        Menu myMenu = new Menu(am.GetActivityNames());
        while (userChoice != "4")
        {
            myMenu.DisplayMenuOptions();
            userChoice = Console.ReadLine();
            int index = int.Parse(userChoice) - 1; // The array starts at 0
            if (userChoice == "1")
            {
                BreathingActivity ba1 = new BreathingActivity(am.GetActivity(index).GetName(),am.GetActivity(index).GetDescription());
                ba1.DisplayStartMessage();
                ba1.RunBreathingActivity();
                ba1.DisplayEndMessage();
            }
            else if (userChoice == "2")
            {
                ReflectingActivity ra1 = new ReflectingActivity(am.GetActivity(index).GetName(),am.GetActivity(index).GetDescription());
                ra1.DisplayStartMessage();
                ra1.RunReflectingActivity();
                ra1.DisplayEndMessage();
            }
            else if (userChoice == "3")
            {
                ListingActivity la1 = new ListingActivity(am.GetActivity(index).GetName(), am.GetActivity(index).GetDescription());
                la1.DisplayStartMessage();
                la1.RunListingActivity();
                la1.DisplayEndMessage();
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("Thank you for participating");
            }
            else 
            {
                Console.WriteLine($"The option {userChoice} does not exist");
            }
        }
    }
}

// Stretch requirements:
// 1 - I created a class called Menu that display all the menu options.
// 2 - The ActivityManager class holds a list of Activity classes.  
// 3 - All the activity name and description are loaded from file.