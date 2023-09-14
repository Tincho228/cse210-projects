using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int score = int.Parse(userInput);
        string letter; 
    
        if (score >= 90) // Letter A
        {
            letter = "A";
        }
        else if (score >= 80) // Letter B
        {
            letter = "B";
        }
        else if (score >= 70) // Letter C
        {
            letter = "C";
        }
        else if (score >= 60) // Letter D
        {
            letter = "D";
        }
        else // Letter F
        {
            letter ="F";
        }
        // Adding sign
        if ((score % 10) >= 7)
        {
            letter += "+";
        } 
        if ((score % 10) < 3)
        {
            letter += "-";
        }

        // Printing out the final letter.
        Console.WriteLine($"Your grade letter is {letter}");
    
        // Determine if the user passed the course.
        if (score >= 70)
        {
            Console.WriteLine("Congratulations!! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, You did not pass the course. Keep trying.");
        }
    }
}