// See https://aka.ms/new-console-template for more information
using System;
using PersonClass;

class Program
{
    static void Main(string[] args)
    {
        MakeSomeGarbage();

        Console.WriteLine($"Memory used before Garbage Collectio: {GC.GetTotalMemory(false):N0}");
        
        // collect garbage
        GC.Collect();

        Console.WriteLine($"Memory used after Garbage Collectio: {GC.GetTotalMemory(true):N0}");

    }

    static void MakeSomeGarbage()
    {
        Person p;

        // crearing some garbage
        for(int i = 0; i < 1000; i++)
        {
            p = new Person();
        }
    }
}
