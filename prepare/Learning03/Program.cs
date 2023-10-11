using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction myFraction = new Fraction();
        Fraction wholeFraction = new Fraction(6);
        Fraction twoFraction = new Fraction(3,4);
        //Getters
        Console.WriteLine(myFraction.GetTop());
        Console.WriteLine(myFraction.GetBottom());
        Console.WriteLine(wholeFraction.GetTop());
        Console.WriteLine(wholeFraction.GetBottom());
        Console.WriteLine(twoFraction.GetTop());
        Console.WriteLine(twoFraction.GetBottom());

        // Setters
        wholeFraction.SetTop(5);

        twoFraction.SetTop(6);
        twoFraction.SetBottom(5);
        
        // Output
        Console.WriteLine(myFraction.GetFractionString());
        Console.WriteLine(myFraction.GetDecimalValue());
        Console.WriteLine(wholeFraction.GetFractionString());
        Console.WriteLine(wholeFraction.GetDecimalValue());
        Console.WriteLine(twoFraction.GetFractionString());
        Console.WriteLine(twoFraction.GetDecimalValue());
    }
}