namespace Mediator
{
    // Общий интерфейс посредника
    interface IChat
    {
        void Send(string mes, User user);
    }
}