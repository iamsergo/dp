namespace Iterator
{
    // Общий интерфейс для итератора
    interface IOddEvenIterator
    {
        object Next();
        bool CanMove();
    }
}