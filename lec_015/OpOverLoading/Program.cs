// See https://aka.ms/new-console-template for more information
using System;
using MoneyClass;

class Program
{
    static void Main(string[] args)
    {
        Money m1 = new Money(10);
        Money m2 = new Money(20);

        Console.WriteLine($"Money m1 = {m1.Amount}, Money m2 = {m2.Amount}");

        Console.WriteLine($"With ordinary sum operator: m1.amount + m2.amount = {m1.Amount+m2.Amount}");

        Console.WriteLine($"With Operator overloading: m1 + m2 = {(m1 + m2).Amount}");
    }
}
