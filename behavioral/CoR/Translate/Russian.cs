namespace CoR
{
    class Russian : Translater
    {
        override public void Translate(string l)
        {
            System.Console.WriteLine("[Russian]");
            if(l != "russian")
            {
                this.Next.Translate(l);
            }
            else
            {
                System.Console.WriteLine("Translated in Russian!");
            }
        }
    }
}