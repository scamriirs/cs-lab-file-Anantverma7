using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a day: ");
        string day = Console.ReadLine().ToLower();

        switch (day)
        {
            case "monday":
            case "tuesday":
            case "wednesday":
            case "thursday":
            case "friday":
                Console.WriteLine($"{day} is a weekday.");
                break;
            case "saturday":
            case "sunday":
                Console.WriteLine($"{day} is a weekend.");
                break;
            default:
                Console.WriteLine("Invalid day entered.");
                break;
        }
    }
}
