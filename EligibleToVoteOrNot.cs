using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        switch (age)
        {
            case int n when (n >= 18):
                Console.WriteLine("You are eligible to vote.");
                break;
            default:
                Console.WriteLine("You are not eligible to vote.");
                break;
        }
    }
}
