namespace AnimalsClass
{
    class Animal
    {
        public void Move()
        {
            Console.WriteLine("Moving .....");
        }

        protected void Drink()
        {
            Console.WriteLine("Drinknig ..");
        }
    }

/* Eagle can access everythin (public, internal, protected) in Animal*/
    class Eagle : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Flying .....");
        }

        // Protected cna be accessed here only not in the main program or outside the class
        public void CallProtected()
        {
            Drink();
        }
    }
}
