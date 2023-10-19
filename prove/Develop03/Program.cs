using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture myScripture = new Scripture();
        myScripture.GetRenderedScripture();
        string userInput = "no";
        while (userInput != "quit"){
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
            if(myScripture.CountVisibleWords() == 0)
            {
                userInput = "quit";
            }
            else
            {    
                myScripture.SetHideWords();
                Console.Clear();
                myScripture.GetRenderedScripture();
            }
        }
    }
}