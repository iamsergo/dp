namespace CoR
{
    class Middleware
    {
        private Translater translater;
        private Translater next;
        public void Use(Translater t)
        {
            if(this.translater == null)
            {
                this.translater = t;
            }
            else
            {
                this.next.Next = t;
            }
            this.next = t;
        }
        public void Translate(string l)
        {
            if(this.translater == null)
            {
                System.Console.WriteLine("Translaters is undefined!");
            }
            else
            {
                this.translater.Translate(l);
            }
        }
    }
}