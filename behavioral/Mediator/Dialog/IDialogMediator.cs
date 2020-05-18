namespace Mediator
{
    // Общий интерфейс посредника
    interface IDialogMediator
    {
        void Notify(Component sender, string e);
    }
}