namespace AnimalsClass
{
    // Abstract class can't be instantiated, can be inherited only
    abstract class Animal
    {
        public void Move()
        {
            Console.WriteLine("Moving .....");
        }

        protected void Drink()  // can be called in children only, not from oustide the class
        {
            Console.WriteLine("Drinknig ..");
        }

        public virtual void Sound()     // Must be virtual to be able to overriddin
        {
            Console.WriteLine("Sound !!");
        }

        public abstract void Food();  // abstract method doesn't have a body, but it must be overridden
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

        // override the abstract method Food
        public override void Food()
        {
            Console.WriteLine("I am an Eagle, my food is ....");
        }
    }

    class Cat : Animal
    {
        public override void Sound()
        {
            base.Sound(); // call the sound method of the base class
            Console.WriteLine("Meow .. Meow .. Meow");
        }

        public override void Food()
        {
            Console.WriteLine("I am a Cat, my food is ....");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Park .. park .. park");
        }

        public override void Food()
        {
            Console.WriteLine("I am a Dog, my food is ....");
        }
    }

    class Duck : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Quack .. quack .. quack");
        }

        public override void Food()
        {
            Console.WriteLine("I am a duck, my food is ....");
        }
    }
}
