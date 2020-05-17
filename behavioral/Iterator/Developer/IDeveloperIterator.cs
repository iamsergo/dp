namespace Iterator
{
    // Общий интерфейс для итератора разработчика
    interface IDeveloperIterator
    {
        object Next();
        bool CanMove();
    }
}