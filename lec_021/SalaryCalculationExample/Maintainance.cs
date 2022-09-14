namespace CompanyClasses
{
    public class Maintainance : Employee
    {
        public const decimal HARDSHIPS = 100M;  //Maintainance employee takes $100 as hardships allowance
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