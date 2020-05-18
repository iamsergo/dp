namespace Iterator
{
    class SequenceApplication
    {
        public void Run()
        {
            var seq = new SequnceIterator();

            System.Console.WriteLine("Start : ");
            while (true)
            {
                System.Console.ReadKey();
                seq.Next();
            }
        }
    }
}