namespace TemplateMethod
{
  class WebSiteApplication
  {
    public void Run()
    {
      WelcomePage wp = new WelcomePage();
      wp.View();

      System.Console.WriteLine();

      NewsPage np = new NewsPage();
      np.View();
    }
  }
}