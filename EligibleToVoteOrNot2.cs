using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter your Age:");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Are you Indian Citizen? (yes/no):");
        string isIndian = Console.ReadLine().ToLower();

        if age >= 18  && isIndian == "yes")
        {
            Console.WriteLine("Eligible to vote");
        }
        else if (age < 18)
        {
            Console.WriteLine("Not Eligible to vote");
        }
        else if (isIndian ! = "yes")
        {
            Console.WriteLine("Not Eligible");
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}