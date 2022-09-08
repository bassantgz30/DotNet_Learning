namespace MoneyClass
{
    public class Money
    {
        private decimal _amount;

        public decimal Amount => this._amount;  //property to return the amount

        // Constructor
        public Money(decimal value)
        {
            this._amount = Math.Round(value, 2);
        }

        // Operator overloading
        public static Money operator + (Money m1, Money m2)
        {
            return new Money(m1._amount + m2._amount);
        }
    }
}
