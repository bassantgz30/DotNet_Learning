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

    static void print(object obj) => Console.WriteLine(obj);
}
