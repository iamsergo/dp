namespace Decorator
{
    class NotifierApplication
    {
        public void Run()
        {
            INotifier n = new Email();

            n = new SMS(n);
            n = new VK(n);

            n.Send("hello");
        }
    }
}