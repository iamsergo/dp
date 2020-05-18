namespace Iterator
{
    interface ISequence
    {
        OddIterator CreateOddIterator();
        EvenIterator CreateEvenIterator();
    }
}