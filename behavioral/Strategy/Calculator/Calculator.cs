namespace Strategy
{
  // Калькулятор - контекст
  class Calculator
  {
    private IAlgo algo;
    public void SetAlgo(IAlgo algo)
    {
      this.algo = algo;
    }
    public void Execute(int a, int b)
    {
      this.algo.Execute(a, b);
    }
  }
}