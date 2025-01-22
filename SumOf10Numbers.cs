using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        Console.Write("The first 10 numbers are: ");

        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            Console.Write(i + (i < 10 ? ", " : ""));
        }

        Console.WriteLine("\nThe sum of the first 10 numbers is: " + sum);
    }
}
