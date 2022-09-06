namespace StockClass
{
    public class Stock
    {
        private string _name;
        private double _price;

        public string Name => this._name;
        public double Price
        {
            get => this._price;
            set => this._price = value;
        }

        public Stock(string name)
        {
            this._name = name;
        }

        public void ChangeStockPriceBy(double percent)
        {
            this._price += Math.Round(this._price * percent, 2);
        }
    }
}
