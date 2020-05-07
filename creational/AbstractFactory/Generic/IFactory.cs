namespace AbstractFactory
{
    interface IFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }
}