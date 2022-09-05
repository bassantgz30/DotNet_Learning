// See https://aka.ms/new-console-template for more information
using System;
using EmployeesClass;
using ReportClass;

class Program
{
    static void Main(string[] args)
    {
        var emps = new Employee[]
        {
            new Employee {Id=10, Name="Nada", Sales=145478, Gender="Female"},
            new Employee {Id=11, Name="Rami", Sales=12347, Gender="Male"},
            new Employee {Id=12, Name="Roka", Sales=60478, Gender="Female"},
            new Employee {Id=13, Name="Mark", Sales=30047, Gender="Male"},
            new Employee {Id=14, Name="Jack", Sales=40478, Gender="Male"},
            new Employee {Id=15, Name="Rasha", Sales=50347, Gender="Female"},
            new Employee {Id=16, Name="Saja", Sales=70478, Gender="Female"},
            new Employee {Id=17, Name="Toni", Sales=20047, Gender="Male"}
        };

        Report report1 = new Report();
        report1.ProcessEmployee_60000P(emps);
        report1.ProcessEmployee_30000_60000(emps);
        report1.ProcessEmployee_30000L(emps);
    }
}
