using System;
using MonthEnumerator;
using DayEnumerator;


class Program
{
    static void Main(string[] args)
    {
        // Simple enumerator
        Console.WriteLine($"{(int)Month.Feb}");

        // loop over enumerator
        foreach(var month in Enum.GetNames(typeof(Month)))
        {
            Console.WriteLine($"{month} = {(int)Enum.Parse(typeof(Month), month)}");
        }


        // Flag enumerator
        var day = (Day.Sat | Day.Sun);

        if(day.HasFlag(Day.WeekEnds))
        {
            Console.WriteLine("Enjoy your weekend!");
        }

    }
}

