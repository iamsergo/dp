namespace Singleton
{
    // Одиночка
    class Database
    {
        // Главное поле
        static private Database instance;
        // Приватный конструктор
        private Database(){}
        // Метод предоставляющий доступ к экземпляру
        static public Database GetInstance()
        {
            if(Database.instance == null)
            {
                Database.instance = new Database();
            }
            return Database.instance;
        }
        // Остальные методы
        public void Query(string q)
        {
            System.Console.WriteLine(q);
        }
    }
}
