namespace TemplateMethod
{
  // Приветственная страница - определяет что-то по-своему
  class WelcomePage : Page
  {
    override protected void Content()
    {
      System.Console.WriteLine("[Welcome_Content]");
    }
  }
}