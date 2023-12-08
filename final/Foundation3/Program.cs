using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Address a1 = new Address("2249 Sycamore Fork Road", "Minneapolis", "Minnesota", "Minnesota", "United States");
        LecturesEvent le = new LecturesEvent("Annual Meeting on Cybersecurity","This event is organized by the World Economic Forum", "December 3, 2023", 6, a1, "John Doe", 50);
        PrintTitle("Lectures Event");
        Console.WriteLine(le.StandardDetails());
        Console.WriteLine(le.FullDetails());
        Console.WriteLine(le.ShortDescription());
        
        Address a2 = new Address("3066 Polk Street", "Tucson", "Arizona", "Arizona", "United States");
        ReceptionsEvent re = new ReceptionsEvent("Wedding", "Actress Jennifer Cunning and politician Raphael Borton","November 30, 2024", 2, a2, "recepctions@plannning-event.com");
        PrintTitle("Receptions Event");
        Console.WriteLine(re.StandardDetails());
        Console.WriteLine(re.FullDetails());
        Console.WriteLine(re.ShortDescription());

        Address a3 = new Address("1332 Drainer Avenue", "Milton", "Florida", "Florida", "United States");
        OutdoorEvent oe = new OutdoorEvent("Baseball Game", "Youth sports events, Junior and Senior", "January 8, 2024", 4, a3, "Mostly sunny");
        PrintTitle("Outdoor Gathering Event");
        Console.WriteLine(oe.StandardDetails());
        Console.WriteLine(oe.FullDetails());
        Console.WriteLine(oe.ShortDescription());

        static void PrintTitle(string text)
        {
            int width = 73;
            Console.WriteLine(new string('/',width));
            Console.WriteLine(text.PadRight(width - (width - text.Length) / 2).PadLeft(width));
            Console.WriteLine(new string('/',width));
        }
    }
}