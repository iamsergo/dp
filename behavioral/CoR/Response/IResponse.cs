namespace CoR
{
    // Общий интерфейс обработчиков - операторы
    interface IResponse
    {
        void SetNext(IResponse nr);
        void Handle(string req);
    }
}