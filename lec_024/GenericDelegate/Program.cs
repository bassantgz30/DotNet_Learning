// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // Generic Interface
        IEnumerable<int> list1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8};
        Console.WriteLine($"Numbers less than 6: ");
        PrintLessThan6(list1);
        Console.WriteLine($"Numbers grater than 5: ");
        PrintGreaterThan5(list1);
        Console.WriteLine($"Even numbers: ");
        PrintEvenNumbers(list1);
        Console.WriteLine($"Odd numbers: ");
        PrintOddNumbers(list1);
    }

    static void PrintLessThan6(IEnumerable<int> arr)
    {
        foreach (int i in arr)
        {
            if(i < 6)
                {Console.WriteLine(i);}
        }
    }

    static void PrintGreaterThan5(IEnumerable<int> arr)
    {
        foreach (int i in arr)
        {
            if(i > 5)
                {Console.WriteLine(i);}
        }
    }

    static void PrintEvenNumbers(IEnumerable<int> arr)
    {
        foreach (int i in arr)
        {
            if(i%2 == 0)
                {Console.WriteLine(i);}
        }
    }

    static void PrintOddNumbers(IEnumerable<int> arr)
    {
        foreach (int i in arr)
        {
            if(i%2 == 1)
                {Console.WriteLine(i);}
        }
    }
}
