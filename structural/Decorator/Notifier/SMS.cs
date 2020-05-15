namespace Decorator
{
    // Смс-оповещание - дополнительное оповещание
    class SMS : Additional
    {
        public SMS(INotifier wrappee) : base(wrappee) {}

        override public void Send(string mes)
        {
            System.Console.WriteLine($"[SMS] : {mes}");
            this.wrappee.Send(mes);
        }
    }
}