using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine($"{ch} is a vowel.");
                break;
            default:
                Console.WriteLine($"{ch} is not a vowel.");
                break;
        }
    }
}

