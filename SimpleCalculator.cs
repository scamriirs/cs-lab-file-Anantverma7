using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation: +, -, *, /");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = 0;

        if (operation == '+')
        {
            result = num1 + num2;
        }
        else if (operation == '-')
        {
            result = num1 - num2;
        }
        else if (operation == '*')
        {
            result = num1 * num2;
        }
        else if (operation == '/')
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid operation");
            return;
        }

        Console.WriteLine("The result of " + num1 + " " + operation + " " + num2 + " is " + result);
    }
}


