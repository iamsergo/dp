namespace Decorator
{
    // ВК-оповещание - дополнительное оповещание
    class VK : Additional
    {
        public VK(INotifier wrappee) : base(wrappee) {}
        
        override public void Send(string mes)
        {
            System.Console.WriteLine($"[VK] : {mes}");
            this.wrappee.Send(mes);
        }
    }
}