namespace Decorator
{
    class FileApplication
    {
        public void Run()
        {
            IDataSource source = new FileDataSource("1.txt");
            source.Write("hello!");

            source = new Encryption(source);
            source = new Compression(source);

            source.Read();
        }
    }
}