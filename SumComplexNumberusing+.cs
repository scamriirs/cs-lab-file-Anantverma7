// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

class Complex
{
    public double Real { get; }
    public double Imaginary { get; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Overloading the + operator
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    public override string ToString()
    {
        return $"{Real} {(Imaginary >= 0 ? "+" : "-")} {Math.Abs(Imaginary)}i";
    }
}

class Program
{
    static void Main()
    {
        Complex c1 = new Complex(3.5, 2.5);
        Complex c2 = new Complex(1.5, -4.5);

        Complex sum = c1 + c2;

        Console.WriteLine($"Sum: {sum}");
    }
}
