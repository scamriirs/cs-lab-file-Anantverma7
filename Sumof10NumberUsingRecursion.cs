using System;

class Program
{
    static int SumOfNumbers(int[] numbers, int index)
    {
        if (index == 0)
            return numbers[0];
        return numbers[index] + SumOfNumbers(numbers, index - 1);
    }

    static void Main()
    {
        int[] numbers = new int[10];
        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = SumOfNumbers(numbers, 9);
        Console.WriteLine("Sum of the entered numbers: " + sum);
    }
}
