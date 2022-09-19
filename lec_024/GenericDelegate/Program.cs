// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public delegate bool Filter(int n);

    static void Main(string[] args)
    {
        // Generic Interface
        IEnumerable<int> list1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8};
        Console.WriteLine($"Numbers less than 6: ");
        PrintNumber(list1, n => n < 6);
        Console.WriteLine($"Numbers grater than 5: ");
        PrintNumber(list1, n => n > 5);
        Console.WriteLine($"Even numbers: ");
        PrintNumber(list1, n => n%2 == 0);
        Console.WriteLine($"Odd numbers: ");
        PrintNumber(list1, n => n%2 == 1);
    }

    static void PrintNumber(IEnumerable<int> arr, Filter filter)
    {
        foreach (int i in arr)
        {
            if(filter(i))
                {Console.WriteLine(i);}
        }
    }

}
