namespace TemplateMethod
{
  // Общий интерфейс, определяющий алгоритм
  abstract class Page
  {
    // Шаблонный метод
    public void View()
    {
      this.Header();
      this.Content();
      this.Footer();
    }
    // Можно переопределить
    virtual protected void Header()
    {
      System.Console.WriteLine("[Header]");
    }
    // Каждая страница реализует по-своему
    abstract protected void Content();
    // Общая реализация
    protected void Footer()
    {
      System.Console.WriteLine("[Footer]");
    }
  }
}