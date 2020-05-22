namespace Strategy
{
    class CalculatorApplication
    {
        public void Run()
        {
          string action = "add";

          Calculator calc = new Calculator();

          switch (action)
          {
            case "add" : calc.SetAlgo(new Additional()); break;
            case "sub" : calc.SetAlgo(new Subtract()); break;
            default: throw new System.Exception("Undefined action!");
          }

          calc.Execute(1,2);
        }
    }
}