namespace Decorator
{
    // Сжатие - конкретный декоратор
    class Compression : DataSourceDecorator
    {
        public Compression(IDataSource wrappee) : base(wrappee) {}

        override public string Read()
        {
            System.Console.WriteLine("[Compression]");
            return this.wrappee.Read();
        }
        override public void Write(string mes)
        {
            System.Console.WriteLine("[Compression]");
            this.wrappee.Write(mes);
        }
    }
}