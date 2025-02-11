using System;

class Person
{
    public string name;
    public int age;

    // Default Constructor
    public Person()
    {
        name = "Anant";
        age = 21;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    static void Main()
    {
        Person p1 = new Person(); // Default constructor is called
        p1.Display();
    }
}
