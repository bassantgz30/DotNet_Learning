namespace PersonClass
{
    public class Person
    {
        public string Name { get; set; }

        public Person()
        {
            //Console.WriteLine("This is the Person's class constructor.");
        }
        
        ~Person()
        {
            //Console.WriteLine("This is the Person's class destructor.");
        }
    }
}
