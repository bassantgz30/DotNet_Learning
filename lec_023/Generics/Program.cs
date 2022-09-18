// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        print(1);
        print("Hello");
        print('c');
    }

    static void print<T>(T value)  // type of T changes acc. to value
    {
        Console.WriteLine($"Type of T is {typeof(T)}");
        Console.WriteLine($"value is {value}");
    }
}
