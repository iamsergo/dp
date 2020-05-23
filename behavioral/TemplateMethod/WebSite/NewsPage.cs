namespace TemplateMethod
{
  // Новостная страница - определяет что-то по-своему
  class NewsPage : Page
  {
    override protected void Header()
    {
      System.Console.WriteLine("[News_Header]");
    }
    override protected void Content()
    {
      System.Console.WriteLine("[News_Content]");
    }
  }
}