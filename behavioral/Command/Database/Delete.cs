namespace Command
{
    // Удаление - конкретная команда
    class Delete : IDbCommand
    {
        public Database db { get; }
        public Delete(Database db)
        {
            this.db = db;
        }
        public void Execute()
        {
            this.db.Delete();
        }
    }
}