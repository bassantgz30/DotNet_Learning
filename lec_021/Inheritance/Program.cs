// See https://aka.ms/new-console-template for more information
using System;
using AnimalsClass;

class Program
{
    static void Main(string[] args)
    {
        Eagle e = new Eagle();
        e.Fly();
        e.Move();
        //e.Drink();  // not allowed bec it's protected method
        e.CallProtected(); // allowed
    }
}
