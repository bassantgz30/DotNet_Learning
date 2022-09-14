namespace CompanyClasses
{
    public class Developer : Employee
    {
        public const decimal BOUNCE = 0.03M; // developer takes +3% per completed task
        public bool TaskDone { get; set; }
      

        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + CalculateBounce();
        }
        private decimal CalculateBounce()
        {
            if (this.TaskDone)
                {return base.CalculateBaseSalary() * BOUNCE;}

            return 0;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nTask Completed: {(this.TaskDone ? "Yes" : "No")}" +
                                    $"\nBounce 3%: ${CalculateBounce():n2}" +
                                    $"\nTotal Salary: ${this.CalculateSalary():n2}";
        }     
    }
}