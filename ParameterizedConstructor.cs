using System;

class Person
{
    public string name;
    public int age;

    // Parameterized Constructor
    public Person(string personName, int personAge)
    {
        name = personName;
        age = personAge;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    static void Main()
    {
        Person p1 = new Person("Alice", 30); // Parameterized constructor is called
        p1.Display();
    }
}
