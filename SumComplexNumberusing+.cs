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

    // Method to add two complex numbers
    public Complex Add(Complex other)
    {
        return new Complex(this.Real + other.Real, this.Imaginary + other.Imaginary);
    }

    public void Display()
    {
        Console.WriteLine($"{Real} {(Imaginary >= 0 ? "+" : "-")} {Math.Abs(Imaginary)}i");
    }
}

class Program
{
    static void Main()
    {
        Complex c1 = new Complex(3.5, 2.5);
        Complex c2 = new Complex(1.5, -4.5);

        Complex sum = c1.Add(c2);

        Console.Write("Sum: ");
        sum.Display();
    }
}
