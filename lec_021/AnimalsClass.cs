namespace AnimalsClass
{
    class Animal
    {
        public void Move()
        {
            Console.WriteLine("Moving .....");
        }
    }

/* Eagle can access everythin (public, internal, protected) in Animal*/
    class Eagle : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Flying .....");
        }
    }
}
