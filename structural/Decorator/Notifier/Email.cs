namespace Decorator
{
    // Базовый оповещатель
    class Email : INotifier
    {
        public void Send(string mes)
        {
            System.Console.WriteLine($"[Email] : {mes}");
        }
    }
}