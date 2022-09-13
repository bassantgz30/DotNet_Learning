namespace AnimalsClass
{
    // Abstract class can't be instantiated, can be inherited only
    abstract class Animal
    {
        public void Move()
        {
            Console.WriteLine("Moving .....");
        }

        protected void Drink()
        {
            Console.WriteLine("Drinknig ..");
        }

        public virtual void Sound()     // Must be virtual to be able to overriddin
        {
            Console.WriteLine("Sound !!");
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

    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow .. Meow .. Meow");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Park .. park .. park");
        }
    }

    class Duck : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Quack .. quack .. quack");
        }
    }
}
