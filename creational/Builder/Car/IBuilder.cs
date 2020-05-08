namespace Builder
{
    // Общий интерфейс строителя
    interface IBuilder
    {
        void Reset();
        void SetSeats(int cs);
        void SetWheel(int cw);
    }
}