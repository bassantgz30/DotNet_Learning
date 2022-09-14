using System;
using CompanyClasses;

class Program
{
    static void Main(string[] args)
    {
        Manager manger = new Manager()
        {Id =  10025,
        Name = "Jenny Rick",
        WorkingHours = 185,
        Wage = 20,
        };
        Console.WriteLine(manger);
        Console.WriteLine("--------------------\n");

        Maintainance maintenance = new Maintainance()
        {Id = 13045,
        Name = "Benny Ros",
        WorkingHours = 181,
        Wage = 11,
        };
        Console.WriteLine(maintenance);
        Console.WriteLine("--------------------\n");

        Sales sales = new Sales()
        {Id = 15023,
        Name = "Sally Mik",
        WorkingHours = 176,
        Wage = 9,
        Commission = 0.05M,
        SalesAmount = 10000M,
        };
        Console.WriteLine(sales);
        Console.WriteLine("--------------------\n");

        Developer developer = new Developer()
        {Id = 17052,
        Name = "Vicky Mars",
        WorkingHours = 177,
        Wage = 17,
        TaskDone = true,
        };
        Console.WriteLine(developer);
        Console.WriteLine("--------------------\n");

    }
}
