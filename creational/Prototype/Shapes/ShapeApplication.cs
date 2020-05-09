namespace Prototype
{
    class ShapeApplication
    {
        public void Run()
        {
            Rectangle r1 = new Rectangle(1 , 2);
            Rectangle r2 = r1.Clone();

            // Поля равны, но объекты - нет.
            // Т.к создается КОПИЯ - новый объект с теми же данными
            System.Console.WriteLine(r1);
            System.Console.WriteLine(r2);
            
            System.Console.WriteLine(r1 == r2);            
        }
    }
}