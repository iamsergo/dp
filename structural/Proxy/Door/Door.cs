namespace Proxy
{
    // Реальная дверь
    class Door : IDoor
    {
        public void Open()
        {
            System.Console.WriteLine("Door is opened!");
        }
        public void Close()
        {
            System.Console.WriteLine("Door is closed!");
        }
    }
}