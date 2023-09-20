using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        string response = "yes";
        while (response == "yes"){
            Random rnd = new Random();
            int magic_number = rnd.Next(1,100);
            int number = -1 ;
            int guesses = 0;
            while (magic_number !=  number)
            {
                guesses +=1;
                Console.Write("What is the magic number: ");
                string user_input = Console.ReadLine();
                number = int.Parse(user_input);
                if (number > magic_number){
                    Console.WriteLine("Lower");
                }
                if (number < magic_number){
                    Console.WriteLine("Higher");
                }
            }
            Console.WriteLine($"You guessed it!, You  made {guesses} guesses");
            Console.Write("Do you want to play again (yes/no)?");
            response = Console.ReadLine();
        }
    }
}