namespace CoR
{
    class English : Translater
    {
        override public void Translate(string l)
        {
            System.Console.WriteLine("[English]");
            if(l != "english")
            {
                this.Next.Translate(l);
            }
            else
            {
                System.Console.WriteLine("Translated in English!");
            }
        }
    }
}