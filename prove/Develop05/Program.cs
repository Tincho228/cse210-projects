using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "-1";
        FileManager fm = new FileManager();
        GoalManager gm = new GoalManager();
        Menu menu = new Menu(gm.GetNamesList());
        while (userChoice != "quit")
        {
                Console.WriteLine($"\nYou have {gm.CountPoints()} points.\n");
                menu.DisplayMenuOptions();
                userChoice = Console.ReadLine();
                if (userChoice == "1") // Create
                {    
                    menu.DiplayGoalOptions();
                    string goalChoice = Console.ReadLine();
                    if (goalChoice == "1")
                    {
                        SimpleGoal sg = new SimpleGoal();
                        sg.SetGoalValues();
                        gm.AddNewGoal(sg);
                    }
                    else if (goalChoice == "2")
                    {
                        EternalGoal eg = new EternalGoal();
                        eg.SetGoalValues();
                        gm.AddNewGoal(eg);
                    }
                    else if (goalChoice == "3")
                    {
                        ChecklistGoal cg = new ChecklistGoal();
                        cg.SetGoalValues();
                        gm.AddNewGoal(cg);
                    }
                    else 
                    {
                        Console.WriteLine($"The option {goalChoice} does not exist");    
                    }
                }
                else if (userChoice == "2") // List
                {
                    gm.DisplayGoals();
                }
                else if (userChoice == "3") // Save
                {
                    Console.Write("Type the name of the file: ");
                    string filename = Console.ReadLine();
                    fm.SaveFile(gm.GetGoals(),gm.CountPoints(), filename);
                }
                else if (userChoice == "4") // Load
                {
                    Console.Write("Type the name of the file: ");
                    string filename = Console.ReadLine();
                    fm.LoadFromFile(filename);
                    gm.LoadGoals(fm.GetGoals());
                    Console.WriteLine("File loaded successfuly.");
                }
                else if (userChoice == "5") // Record
                {
                    menu.DisplayRecordEventOptions(gm.GetGoalNames());
                    int index = int.Parse(Console.ReadLine());
                    gm.RecordEvent(index - 1);
                    Console.WriteLine($"You now have {gm.CountPoints()} points!!!");
                }
                else if (userChoice == "6") // Quit
                {
                    if(fm.IsSaved())
                    {
                        Console.WriteLine("Thank you for participating");
                        userChoice = "quit";
                    }
                    else{
                        Console.Write("Goals are not saved. Do you want to save the file? (y / n)");
                        string response = Console.ReadLine();
                        if(response == "y")
                        {
                            Console.Write("Type the name of the file: ");
                            string filename = Console.ReadLine();
                            fm.SaveFile(gm.GetGoals(),gm.CountPoints(), filename);
                            Console.WriteLine("Thank you for participating");
                            userChoice = "quit";
                        }
                        else if (response == "n")
                        {
                             Console.WriteLine("Thank you for participating");
                             userChoice = "quit";
                        }
                        else 
                        {
                            Console.WriteLine($"The option {response} does not exist");
                        }
                    }
                }
                else // Wrong choice
                {
                    Console.WriteLine($"The option {userChoice} does not exist");
                }
        }
    }
}
                // Strech 
// 1. When bonus is earned, an animation is displayed.
// 2. A prompt is displayed if you quit without saving your goals.
// 3. The Menu class construct and displays all the main, record and create menus.
// 4. The Goal Manager class holds the list of goals, provides information for menus and displays.
// 5. File Manager class loads and saves from file.
