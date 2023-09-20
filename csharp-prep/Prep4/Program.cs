using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int userNumber = -99999;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNumber !=0)
        {
            Console.Write("Enter number: ");
            string user_input = Console.ReadLine();
            userNumber = int.Parse(user_input);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        
        int largest = -1;
        int smallest = 9999;
        foreach (int item in numbers)
        {
            sum += item;
            if (item > largest){
                largest = item;
            }
            if ((0 < item) && (item < smallest)) {
                smallest = item;
            }
        }
        double average = numbers.Average();
        // Second way average = (float(sum))/numbers.Count();
        numbers.Sort();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}