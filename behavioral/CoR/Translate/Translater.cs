namespace CoR
{
    abstract class Translater
    {
        public Translater Next { get; set; }
        abstract public void Translate(string l);
    }
}