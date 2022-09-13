// See https://aka.ms/new-console-template for more information
using System;
using AnimalsClass;

class Program
{
    static void Main(string[] args)
    {
        //Animal a = new Animal(); // not allowed bec it's an abstract class

        Console.WriteLine("***** Eagle *****");
        Eagle eagle = new Eagle();
        eagle.Fly();
        eagle.Move();
        //e.Drink();  // not allowed bec it's protected method
        eagle.CallProtected(); // allowed
        Console.WriteLine();

        Console.WriteLine("***** Cat *****");
        Cat cat = new Cat();
        cat.Move();
        cat.Sound();
        Console.WriteLine();

        Console.WriteLine("***** Dog *****");
        Dog dog = new Dog();
        dog.Move();
        dog.Sound();
        Console.WriteLine();

        Console.WriteLine("***** Duck *****");
        Duck duck = new Duck();
        duck.Move();
        duck.Sound();
        Console.WriteLine();
    }
}
