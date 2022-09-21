// See https://aka.ms/new-console-template for more information
using System;
using ProjectClasses;


class Project
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee {id=1504, name="Jina", salary=6500, department="testing"};
        Employee e2 = new Employee {id=1504, name="Jina", salary=6500, department="testing"};

        Console.WriteLine($"e1 is identical to e2? {e1 == e2}");  // Compare refrences i.e. memorey location

        Employee e3 = e2;   // both point to the same memory location
        Console.WriteLine($"e3 is identical to e2? {e3 == e2}");

    }
}
