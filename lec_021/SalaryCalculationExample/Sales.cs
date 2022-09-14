namespace CompanyClasses
{
    public class Sales : Employee
    {
        protected decimal SalesAmount { get; set; }
        protected decimal Commission { get; set; }

        // Constructor
        public Sales(int id, string name, decimal workingHours, decimal wage, decimal amount, 
        decimal commision) : base(id, name, workingHours, wage)
        {
            this.SalesAmount = amount;
            this.Commission = commision;
        }
        
        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + CalculateBounce();
        }

        private decimal CalculateBounce()
        {
            return this.SalesAmount * this.Commission;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nTotal Sales: ${this.SalesAmount:n2}" +
                                    $"\nCommission: {this.Commission:n2}" +
                                    $"\nBounce: ${CalculateBounce():n2}" +
                                    $"\nTotal Salary: ${this.CalculateSalary():n2}";
        }     
    }
}