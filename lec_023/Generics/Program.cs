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

    static void print(int i) => Console.WriteLine(i);
    static void print(string s) => Console.WriteLine(s);
    static void print(char c) => Console.WriteLine(c);
}