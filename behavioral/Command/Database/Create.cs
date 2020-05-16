namespace Command
{
    // Создание - конкретная команда
    class Create : IDbCommand
    {
        public Database db { get; }
        public Create(Database db)
        {
            this.db = db;
        }
        public void Execute()
        {
            this.db.Create();
        }
    }
}