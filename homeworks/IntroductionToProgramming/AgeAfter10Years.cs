using System;

class AgeAfter10Years
{
    static void Main()
    {
        DateTime today = new DateTime(2015, 11, 01);
        
        Console.Write("Write down your Birthday YYYY-MM-DD: ");
        DateTime birthdate = DateTime.Parse(Console.ReadLine()); 
        Console.WriteLine("Now: " + (today.Year - birthdate.Year));
        Console.WriteLine("After 10 years: " + (today.Year - birthdate.Year + 10));
    }
}
