namespace Composite
{
    class OrderApplication
    {
        public void Run()
        {
            Phone p = new Phone(1000);
            TV tv = new TV(2000);

            Box b = new Box();
            b.Add(p);
            b.Add(p);
            b.Add(tv);

            System.Console.WriteLine(b.Price());
        }
    }
}