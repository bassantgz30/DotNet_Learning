using System;
using EmployeesClass;

namespace ReportClass
{
    public class Report
    {
        public void ProcessEmployee_60000P(Employee[] employees)
        {
            Console.WriteLine("Employees with sales more than or equal 60,000");
            Console.WriteLine("===================================");

            foreach(var e in employees)
            {
                if(e.Sales >= 60000)
                {Console.WriteLine($"{e.Id} , {e.Name} , {e.Gender} , {e.Sales}");}
            }
            Console.WriteLine("\n\n");
        }

        public void ProcessEmployee_30000_60000(Employee[] employees)
        {
            Console.WriteLine("Employees with Sales between 30,000 and 60,000 plus sales.");
            Console.WriteLine("===================================");

            foreach(var e in employees)
            {
                if((e.Sales >= 30000) && (e.Sales < 60000))
                {Console.WriteLine($"{e.Id} , {e.Name} , {e.Gender} , {e.Sales}");}
            }
            Console.WriteLine("\n\n");
        }

        public void ProcessEmployee_30000L(Employee[] employees)
        {
            Console.WriteLine("Employees with Sales Less than 30,000.");
            Console.WriteLine("===================================");

            foreach(var e in employees)
            {
                if(e.Sales < 30000)
                {Console.WriteLine($"{e.Id} , {e.Name} , {e.Gender} , {e.Sales}");}
            }
            Console.WriteLine("\n\n");
        }
    }

}