namespace Decorator
{
    // Обертка
    class DataSourceDecorator : IDataSource
    {
        protected IDataSource wrappee;
        public DataSourceDecorator(IDataSource wrappee)
        {
            this.wrappee = wrappee;
        }
        virtual public string Read()
        {
            System.Console.WriteLine("[DataSourceDecorator]");
            return this.wrappee.Read();
        }
        virtual public void Write(string mes)
        {
            System.Console.WriteLine("[DataSourceDecorator]");
            this.wrappee.Write(mes);
        }
    }
}