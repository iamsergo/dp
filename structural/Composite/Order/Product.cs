namespace Composite
{
    // Продукт - элементарная часть заказа
    class Product : IOrder
    {
        protected int price;
        public Product(int price)
        {
            this.price = price;
        }

        public int Price()
        {
            return this.price;
        }
    }
}