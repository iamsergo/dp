namespace Command
{
    // Общий интерфейс для команд
    interface IDbCommand
    {
        Database db { get; }
        void Execute();
    }
}