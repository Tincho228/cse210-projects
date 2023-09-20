using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);

        //**********************************************//
        // My functions
        
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName(){
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber(){
            Console.Write("Please enter your favorite number: ");
            string user_input = Console.ReadLine();
            int number = int.Parse(user_input);
            return number;
        }
        static int SquareNumber(int number){
            int square = number * number;
            return square;
        }
        static void DisplayResult (string name, int square){
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}