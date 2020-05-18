namespace Mediator
{
    // Кнопка - конкретный посредник
    class Button : Component
    {
        public Button(IDialogMediator dialog) : base(dialog) {}
    }
}