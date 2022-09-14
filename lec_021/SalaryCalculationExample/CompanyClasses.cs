namespace CompanyClasses
{
    public class Employee
    {
        public const int MIN_WORK_HOURS = 176;
        public const decimal OVERTIME_RATE = 1.25M;
        public int Id { get; set; }
        public string Name { get; set;}
        public decimal WorkingHours { get; set;}
        public decimal Wage { get; set;}

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