using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("This animal eats food");
    }
}

class Dog : Animal

{
    public void Bark() {
        Console.WriteLine("This dog Barks");
    }

    class program
    {
        static void Main()
        {
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Bark();
        }
    }