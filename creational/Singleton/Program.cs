using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db1 = Database.GetInstance();
            Database db2 = Database.GetInstance();

            System.Console.WriteLine(db1 == db2);
        }
    }
}
