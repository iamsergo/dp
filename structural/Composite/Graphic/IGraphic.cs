namespace Composite
{
    // Общий интерфейс для графических компонентов
    interface IGraphic
    {
        void Move(int x, int y);
        void Draw();
    }
}