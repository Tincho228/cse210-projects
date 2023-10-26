using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        
        MathAssignment mathAssignment = new MathAssignment("Martin Quintero","Multiplication","7.5","8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        WritingAssignment writingAssignment = new WritingAssignment("Martin Quintero","Classic Art","The world of art");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}