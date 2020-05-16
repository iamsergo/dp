namespace Command
{
    class DatabaseApplication
    {
        public void Run()
        {
            Database db = new Database();

            Developer dv = new Developer(
                new Create(db),
                new Delete(db)
            );

            dv.Create();
            dv.Delete();
        }
    }
}