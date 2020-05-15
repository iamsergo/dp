namespace Decorator
{
    // Шифрование - конкретная обертка
    class Encryption : DataSourceDecorator
    {
        public Encryption(IDataSource wrappee) : base(wrappee) {}

        override public string Read()
        {
            System.Console.WriteLine("[Encryption]");
            return this.wrappee.Read();
        }
        override public void Write(string mes)
        {
            System.Console.WriteLine("[Encryption]");
            this.wrappee.Write(mes);
        }
    }
}