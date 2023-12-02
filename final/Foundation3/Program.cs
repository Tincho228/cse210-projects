using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Address a1 = new Address("2249 Sycamore Fork Road","Minneapolis","Minnesota","Minnesota","United States");
        LecturesEvent le = new LecturesEvent("Marriage","Actress Parineeti Chopra and politician Raghav Chadha ","December 3,2023",6,a1,"John Doe",50);
        // Console.WriteLine(le.StandardDetails());
        // Console.WriteLine(le.FullDetails());
        // Console.WriteLine(le.ShortDescription());


        Address a2 = new Address("3066 Polk Street","Tucson","Arizona","Arizona","United States");
        ReceptionsEvent re = new ReceptionsEvent("Drinks and cars","Check new cars, old and new.","Novemeber 30, 2024",2,a2,"recepctions@plannning-event.com");
        Console.WriteLine(re.StandardDetails());
        Console.WriteLine(re.FullDetails());
        Console.WriteLine(re.ShortDescription());

        Address a3 = new Address("1332 Drainer Avenue","Milton","Florida","Florida","United States");


        Address a4 = new Address("2175 Delaware Avenue","San Francisco","California","California","United States");
    }
}