namespace Transportation
{
    abstract class Vehicle
    {
        protected string Brand { get; set; }
        protected string Model { get; set; }
        protected int Year { get; set; }

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        
    }
}