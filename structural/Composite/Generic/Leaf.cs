namespace Composite
{
    // Элементарный компонент
    class Leaf : IComponent
    {
        public void Method()
        {
            System.Console.WriteLine("[Leaf]");
        }
    }
}