using System;
using CompanyClasses;

class Program
{
    static void Main(string[] args)
    {
        Manager manger = new Manager(
        10025,
        "Jenny Rick",
        185,
        20
        );
        Console.WriteLine(manger);
        Console.WriteLine("--------------------\n");

        Maintainance maintenance = new Maintainance(
        13045,
        "Benny Ros",
        181,
        11
        );
        Console.WriteLine(maintenance);
        Console.WriteLine("--------------------\n");

        Sales sales = new Sales(
        15023,
        "Sally Mik",
        176,
        9,
        0.05M,
        10000M
        );
        Console.WriteLine(sales);
        Console.WriteLine("--------------------\n");

        Developer developer = new Developer(
        17052,
        "Vicky Mars",
        177,
        17,
        true
        );
        Console.WriteLine(developer);
        Console.WriteLine("--------------------\n");

    }
}
