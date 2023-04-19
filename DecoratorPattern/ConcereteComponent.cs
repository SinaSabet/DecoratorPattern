namespace DecoratorPattern
{
    public  class ConcereteComponent : Component 
    {
        public override void operation()
        {
            Console.WriteLine("ConcereteComponent Operation");
        }

    }
}
