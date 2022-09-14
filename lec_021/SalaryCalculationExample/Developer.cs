namespace CompanyClasses
{
    public class Developer : Employee
    {
        private const decimal BOUNCE = 0.03M; // developer takes +3% per completed task
        protected bool TaskDone { get; set; }
      
        // Constructor
        public Developer(int id, string name, decimal workingHours, decimal wage, 
        bool done) : base(id, name, workingHours, wage)
        {
            this.TaskDone = done;
        }
        
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