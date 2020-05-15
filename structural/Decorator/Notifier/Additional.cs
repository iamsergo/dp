namespace Decorator
{
    // Дополнительные оповещатели - общий класс обертки
    class Additional : INotifier
    {
        protected INotifier wrappee;
        public Additional(INotifier wrappee)
        {
            this.wrappee = wrappee;
        }

        virtual public void Send(string mes)
        {
            this.wrappee.Send(mes);
        }
    }
}