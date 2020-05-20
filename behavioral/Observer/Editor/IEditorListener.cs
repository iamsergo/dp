namespace Observer
{
    // Общий интерфейс подписчиков
    interface IEditorListener
    {
        void Update(string data);
    }
}