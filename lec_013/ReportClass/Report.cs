using System;
using EmployeesClass;

namespace ReportClass
{
    public class Report
    {
        // Create a delegate to handel different conditions of reports
        // Delegate is a method but witgout a body.
        public delegate bool EmployeeFilter(Employee e);

        // Creat one general method for reports
        public void ProcessEmployee(Employee[] employees, string reportTitle, EmployeeFilter empFilter)
        {
            Console.WriteLine(reportTitle);
            Console.WriteLine("===================================");

            foreach(var e in employees)
            {
                if(empFilter(e))
                {Console.WriteLine($"{e.Id} , {e.Name} , {e.Gender} , {e.Sales}");}
            }
            Console.WriteLine("\n\n");
        }
    }

}
