namespace CoR
{
    class France : Translater
    {
        override public void Translate(string l)
        {
            System.Console.WriteLine("[France]");
            if(l != "france")
            {
                this.Next.Translate(l);
            }
            else
            {
                System.Console.WriteLine("Translated in France!");
            }
        }
    }
}