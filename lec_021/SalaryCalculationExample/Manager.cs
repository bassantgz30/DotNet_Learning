namespace CompanyClasses
{
    public class Manager : Employee
    {
        private const decimal BENEFIT = 0.05M;   // Manager takes +5% of the base salary
        
        // Constructor
        public Manager(int id, string name, decimal workingHours, decimal wage) : base(id, name, workingHours, wage)
        {
            
        }

        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + CalculateBenefit();
        }
        
        private decimal CalculateBenefit()
        {
            return base.CalculateBaseSalary() * BENEFIT; 
        }

        public override string ToString()
        {
            return base.ToString() + $"\nBenefit 5%: ${CalculateBenefit():n2}" +
                                    $"\nTotal Salary: ${this.CalculateSalary():n2}";
        }     
    }
}