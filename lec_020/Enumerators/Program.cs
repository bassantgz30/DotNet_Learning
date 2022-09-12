using System;
using MonthEnumerator;
using DayEnumerator;


class Program
{
    static void Main(string[] args)
    {
        // Simple enumerator
        Console.WriteLine($"{(int)Month.Feb}");

        // Flag enumerator
        var day = (Day.Sat | Day.Sun);

        if(day.HasFlag(Day.WeekEnds))
        {
            Console.WriteLine("Enjoy your weekend!");
        }

    }
}

