using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");
        Journal myJournal = new Journal(); 
        string choice = "-1";
        while (choice != "5")
        {
            Entry myEntry = new Entry();
            Prompt myPrompt = new Prompt();
            Console.WriteLine("Please select one of the following choices:");
            // MAIN MENU
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
             
            if (choice == "1")
            {
                string question = myPrompt.PromptGenerator();
                Console.WriteLine(question);
                myEntry._response = Console.ReadLine();
                myEntry._prompt = question;
                DateTime currentDate = DateTime.Now;
                myEntry._date = currentDate.ToShortDateString();
                myJournal._entries.Add(myEntry);
            }
            else if (choice == "2")
            {
                Console.WriteLine("Journal Display");
                myJournal.DisplayJournal();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Loading from file");
                Console.Write("Please enter the name of the file txt: ");
                myJournal._filename = Console.ReadLine();
                myJournal.LoadFromFile();
                Console.WriteLine($"The file {myJournal._filename} was loaded successfully");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Saving to a file");
                Console.Write("Please enter the name of the file txt: ");
                myJournal._filename  = Console.ReadLine();
                myJournal.SaveToFile();
                Console.WriteLine($"The file {myJournal._filename} was saved successfully");
            }
            else if (choice == "5")
            {
                Console.WriteLine("See you later!");
            }
            else
            {
                Console.WriteLine("************************************");
                Console.WriteLine($"{choice} It is a wrong option!!!! You must choose between 1 to 5");
                Console.WriteLine("************************************");
            }

        }
        
    }
}