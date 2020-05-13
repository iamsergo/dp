namespace Composite
{
    class Application
    {
        public void Run()
        {
            var l1 = new Leaf();
            var l2 = new Leaf();

            var c  = new SimpleContainer();
            c.Add(l1);
            c.Add(l2);

            c.Method();
        }
    }
}