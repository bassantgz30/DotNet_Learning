namespace CompanyClasses
{
    public class Sales : Employee
    {
        public decimal SalesAmount { get; set; }
        public decimal Commission { get; set; }

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