namespace Prototype
{
    // Интерфейс, поддерживающий клонирование
    interface ICloneable<out T>
    {
        T Clone();
    }
}