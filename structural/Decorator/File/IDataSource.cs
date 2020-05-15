namespace Decorator
{
    // Общий интерфейс для источников файлов
    interface IDataSource
    {
        string Read();
        void Write(string data);
    }
}