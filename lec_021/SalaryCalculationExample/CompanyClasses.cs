namespace CompanyClasses
{
    public class Employee
    {
        private const int MIN_WORK_HOURS = 176;
        private const decimal OVERTIME_RATE = 1.25M;

        protected int Id { get; set; }
        protected string Name { get; set;}
        protected decimal WorkingHours { get; set;}
        protected decimal Wage { get; set;}

        // Constructor
        protected Employee(int id, string name, decimal workingHours, decimal wage)
        {
            Id = id;
            Name = name;
            WorkingHours = workingHours;
            Wage = wage;
        }

        protected virtual decimal CalculateSalary()
        { 
            return CalculateBaseSalary() + CalculateOverTimeSalary();
        }

        public virtual decimal CalculateBaseSalary()
        {
            return this.Wage*MIN_WORK_HOURS;
        }

        public virtual decimal CalculateOverTimeSalary()
        {
            var addtionalHours = this.WorkingHours - MIN_WORK_HOURS;

            return addtionalHours*Wage*OVERTIME_RATE;
        }

        public override string ToString()
        {
            var position = GetType().ToString().Replace("CompanyClasses.", "");
            return $"{position}" +
                   $"\nId: {this.Id}" +
                   $"\nName: {this.Name}" +
                   $"\nWorking Hours: {this.WorkingHours} hrs" +
                   $"\nHour Rate: {this.Wage:n2} $/hr" +
                   $"\nBase salary: ${CalculateBaseSalary():n2}" +
                   $"\nOvertime: ${CalculateOverTimeSalary():n2}";
        }
    }
}