namespace Prototype
{
    class MitosApplication
    {
        public void Run()
        {
            Cell c1 = new Cell(true);
            Cell c2 = c1.Clone();

            System.Console.WriteLine(c1);
            System.Console.WriteLine(c2);
            System.Console.WriteLine(c1 == c2);
        }
    }
}