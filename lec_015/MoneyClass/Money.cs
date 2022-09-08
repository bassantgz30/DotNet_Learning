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
    }
}
