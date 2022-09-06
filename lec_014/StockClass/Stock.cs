namespace StockClass
{
    public delegate void StockPriceChangeHandler(Stock stock, double oldPrice);
    public class Stock
    {
        private string _name;
        private double _price;

        public event StockPriceChangeHandler OnPriceCahnged;
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
            double oldPrice = this._price;
            this._price += Math.Round(this._price * percent, 2);

            if(OnPriceCahnged != null)  //there is a subscriber (event)
            {
                OnPriceCahnged(this, oldPrice);  // publish the event9
            }
            
        }
    }
}
