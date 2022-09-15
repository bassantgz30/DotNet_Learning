namespace Transportation
{
    class Caterpillar : Vehicle, ILoader
    {
        public Caterpillar(string brand, string model, int year) : base(brand, model, year)
        {
            
        }

        public void Load()
        {
            Console.WriteLine("Loading");
        }

        public void Unload()
        {
            Console.WriteLine("Unloading");
        }
    }
}