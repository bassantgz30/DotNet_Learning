namespace CompanyClasses
{
    public class Maintainance : Employee
    {
        private const decimal HARDSHIPS = 100M;  //Maintainance employee takes $100 as hardships allowance
        
        // Constructor
        public Maintainance(int id, string name, decimal workingHours, decimal wage) : base(id, name, workingHours, wage)
        {
            
        }

        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + HARDSHIPS;
        }
      
        public override string ToString()
        {
            return base.ToString() + $"\nHardships: ${HARDSHIPS:n2}" +
                                    $"\nTotal Salary: ${this.CalculateSalary():n2}";
        }     
    }
}