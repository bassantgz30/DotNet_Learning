// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public delegate bool Filter<in T>(T n);     // Generic delegate

    static void Main(string[] args)
    {
        // Generic Interface
        IEnumerable<int> list1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8};
        Console.WriteLine($"Numbers less than 6: ");
        PrintElement(list1, n => n < 6);
        Console.WriteLine($"Numbers grater than 5: ");
        PrintElement(list1, n => n > 5);
        Console.WriteLine($"Even numbers: ");
        PrintElement(list1, n => n%2 == 0);
        Console.WriteLine($"Odd numbers: ");
        PrintElement(list1, n => n%2 == 1);


        IEnumerable<double> list2 = new double[] {10.5, 12.45, 5.778, 6.01, 4.56, 8.89, 14.23, 1.9};
        Console.WriteLine($"Numbers less than 7.5: ");
        PrintElement(list2, n => n < 7.5);
        Console.WriteLine($"Numbers grater than 5.8: ");
        PrintElement(list2, n => n > 5.8);

        
        IEnumerable<string> list3 = new string[] {"abc", "klmn", "x", "hijop", "defg", "xx"};
        Console.WriteLine($"String with length less than 4: ");
        PrintElement(list3, s => s.Length < 4);
        Console.WriteLine($"Sringd with length greater than or equal 4: ");
        PrintElement(list3, s => s.Length >= 4);
    }

    static void PrintElement<T>(IEnumerable<T> arr, Filter<T> filter)
    {
        foreach (var i in arr)
        {
            if(filter(i))
                {Console.WriteLine(i);}
        }
    }

}
