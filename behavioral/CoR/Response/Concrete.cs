namespace CoR
{
    // Конкретный оператор - помогает с конкретной(самой узкой) задачей
    class Concrete : IResponse
    {
        private IResponse nr;
        public void SetNext(IResponse nr)
        {
            this.nr = nr;
        }
        public void Handle(string req)
        {
            if (req == "not undestand")
            {
                System.Console.WriteLine("[Concrete] : Task is done!");
            }
            else
            {
                try
                {                    
                    this.nr.Handle(req);
                    System.Console.WriteLine("[Concrete] ->");
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("This task is can not handle!");
                }
            }
        }
    }
}